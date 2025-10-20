using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StocktakesController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public StocktakesController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stocktakes>>> Getstocktakes()
        {
            return await _context.stocktakes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stocktakes>> GetStocktakes(int id)
        {
            var stocktakes = await _context.stocktakes.FindAsync(id);

            if (stocktakes == null)
            {
                return NotFound();
            }

            return stocktakes;
        }

        [HttpPost]
        public async Task<ActionResult<Stocktakes>> PostStocktakes(Stocktakes stocktakes)
        {
            _context.stocktakes.Add(stocktakes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStocktakes", new { id = stocktakes.id }, stocktakes);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStocktakes(int id, Stocktakes stocktakes)
        {
            if (id != stocktakes.id)
            {
                return BadRequest();
            }

            _context.Entry(stocktakes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StocktakesExists(id))
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
        public async Task<IActionResult> DeleteStocktakes(int id)
        {
            var stocktakes = await _context.stocktakes.FindAsync(id);
            if (stocktakes == null)
            {
                return NotFound();
            }

            _context.stocktakes.Remove(stocktakes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StocktakesExists(int id)
        {
            return _context.stocktakes.Any(e => e.id == id);
        }
    }
}