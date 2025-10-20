using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CashsaleController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public CashsaleController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cashsale>>> Getcashsale()
        {
            return await _context.cashsale.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cashsale>> GetCashsale(int id)
        {
            var cashsale = await _context.cashsale.FindAsync(id);

            if (cashsale == null)
            {
                return NotFound();
            }

            return cashsale;
        }

        [HttpPost]
        public async Task<ActionResult<Cashsale>> PostCashsale(Cashsale cashsale)
        {
            _context.cashsale.Add(cashsale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashsale", new { id = cashsale.id }, cashsale);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCashsale(int id, Cashsale cashsale)
        {
            if (id != cashsale.id)
            {
                return BadRequest();
            }

            _context.Entry(cashsale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CashsaleExists(id))
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
        public async Task<IActionResult> DeleteCashsale(int id)
        {
            var cashsale = await _context.cashsale.FindAsync(id);
            if (cashsale == null)
            {
                return NotFound();
            }

            _context.cashsale.Remove(cashsale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CashsaleExists(int id)
        {
            return _context.cashsale.Any(e => e.id == id);
        }
    }
}