using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public AssetsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assets>>> Getassets()
        {
            return await _context.assets.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Assets>> GetAssets(int id)
        {
            var assets = await _context.assets.FindAsync(id);

            if (assets == null)
            {
                return NotFound();
            }

            return assets;
        }

        [HttpPost]
        public async Task<ActionResult<Assets>> PostAssets(Assets assets)
        {
            _context.assets.Add(assets);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssets", new { id = assets.id }, assets);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssets(int id, Assets assets)
        {
            if (id != assets.id)
            {
                return BadRequest();
            }

            _context.Entry(assets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetsExists(id))
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
        public async Task<IActionResult> DeleteAssets(int id)
        {
            var assets = await _context.assets.FindAsync(id);
            if (assets == null)
            {
                return NotFound();
            }

            _context.assets.Remove(assets);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssetsExists(int id)
        {
            return _context.assets.Any(e => e.id == id);
        }
    }
}