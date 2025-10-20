using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsfieldsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ReportsfieldsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reportsfields>>> Getreportsfields()
        {
            return await _context.reportsfields.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reportsfields>> GetReportsfields(int id)
        {
            var reportsfields = await _context.reportsfields.FindAsync(id);

            if (reportsfields == null)
            {
                return NotFound();
            }

            return reportsfields;
        }

        [HttpPost]
        public async Task<ActionResult<Reportsfields>> PostReportsfields(Reportsfields reportsfields)
        {
            _context.reportsfields.Add(reportsfields);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReportsfields", new { id = reportsfields.id }, reportsfields);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReportsfields(int id, Reportsfields reportsfields)
        {
            if (id != reportsfields.id)
            {
                return BadRequest();
            }

            _context.Entry(reportsfields).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportsfieldsExists(id))
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
        public async Task<IActionResult> DeleteReportsfields(int id)
        {
            var reportsfields = await _context.reportsfields.FindAsync(id);
            if (reportsfields == null)
            {
                return NotFound();
            }

            _context.reportsfields.Remove(reportsfields);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReportsfieldsExists(int id)
        {
            return _context.reportsfields.Any(e => e.id == id);
        }
    }
}