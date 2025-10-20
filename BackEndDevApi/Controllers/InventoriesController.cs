using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoriesController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public InventoriesController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventories>>> Getinventories()
        {
            return await _context.inventories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Inventories>> GetInventories(int id)
        {
            var inventories = await _context.inventories.FindAsync(id);

            if (inventories == null)
            {
                return NotFound();
            }

            return inventories;
        }

        [HttpPost]
        public async Task<ActionResult<Inventories>> PostInventories(Inventories inventories)
        {
            _context.inventories.Add(inventories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventories", new { id = inventories.id }, inventories);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventories(int id, Inventories inventories)
        {
            if (id != inventories.id)
            {
                return BadRequest();
            }

            _context.Entry(inventories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoriesExists(id))
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
        public async Task<IActionResult> DeleteInventories(int id)
        {
            var inventories = await _context.inventories.FindAsync(id);
            if (inventories == null)
            {
                return NotFound();
            }

            _context.inventories.Remove(inventories);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoriesExists(int id)
        {
            return _context.inventories.Any(e => e.id == id);
        }
    }
}