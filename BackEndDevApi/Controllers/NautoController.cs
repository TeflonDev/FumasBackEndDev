using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NautoController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public NautoController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nauto>>> Getnauto()
        {
            return await _context.nauto.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Nauto>> GetNauto(int id)
        {
            var nauto = await _context.nauto.FindAsync(id);

            if (nauto == null)
            {
                return NotFound();
            }

            return nauto;
        }

        [HttpPost]
        public async Task<ActionResult<Nauto>> PostNauto(Nauto nauto)
        {
            _context.nauto.Add(nauto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNauto", new { id = nauto.id }, nauto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNauto(int id, Nauto nauto)
        {
            if (id != nauto.id)
            {
                return BadRequest();
            }

            _context.Entry(nauto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NautoExists(id))
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
        public async Task<IActionResult> DeleteNauto(int id)
        {
            var nauto = await _context.nauto.FindAsync(id);
            if (nauto == null)
            {
                return NotFound();
            }

            _context.nauto.Remove(nauto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NautoExists(int id)
        {
            return _context.nauto.Any(e => e.id == id);
        }
    }
}