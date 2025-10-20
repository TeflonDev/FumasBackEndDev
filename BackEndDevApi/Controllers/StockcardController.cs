using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockcardController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public StockcardController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stockcard>>> Getstockcard()
        {
            return await _context.stockcard.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stockcard>> GetStockcard(int id)
        {
            var stockcard = await _context.stockcard.FindAsync(id);

            if (stockcard == null)
            {
                return NotFound();
            }

            return stockcard;
        }

        [HttpPost]
        public async Task<ActionResult<Stockcard>> PostStockcard(Stockcard stockcard)
        {
            _context.stockcard.Add(stockcard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStockcard", new { id = stockcard.id }, stockcard);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockcard(int id, Stockcard stockcard)
        {
            if (id != stockcard.id)
            {
                return BadRequest();
            }

            _context.Entry(stockcard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockcardExists(id))
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
        public async Task<IActionResult> DeleteStockcard(int id)
        {
            var stockcard = await _context.stockcard.FindAsync(id);
            if (stockcard == null)
            {
                return NotFound();
            }

            _context.stockcard.Remove(stockcard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StockcardExists(int id)
        {
            return _context.stockcard.Any(e => e.id == id);
        }
    }
}