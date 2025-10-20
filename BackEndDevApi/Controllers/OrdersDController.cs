using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersDController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public OrdersDController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdersD>>> Getorders_d()
        {
            return await _context.orders_d.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrdersD>> GetOrdersD(int id)
        {
            var ordersD = await _context.orders_d.FindAsync(id);

            if (ordersD == null)
            {
                return NotFound();
            }

            return ordersD;
        }

        [HttpPost]
        public async Task<ActionResult<OrdersD>> PostOrdersD(OrdersD ordersD)
        {
            _context.orders_d.Add(ordersD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdersD", new { id = ordersD.idid }, ordersD);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdersD(int id, OrdersD ordersD)
        {
            if (id != ordersD.idid)
            {
                return BadRequest();
            }

            _context.Entry(ordersD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersDExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdersD(int id)
        {
            var ordersD = await _context.orders_d.FindAsync(id);
            if (ordersD == null)
            {
                return NotFound();
            }

            _context.orders_d.Remove(ordersD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdersDExists(int id)
        {
            return _context.orders_d.Any(e => e.idid == id);
        }
    }
}