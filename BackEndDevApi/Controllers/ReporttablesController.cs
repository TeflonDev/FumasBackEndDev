using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReporttablesController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ReporttablesController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reporttables>>> Getreporttables()
        {
            return await _context.reporttables.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reporttables>> GetReporttables(int id)
        {
            var reporttables = await _context.reporttables.FindAsync(id);

            if (reporttables == null)
            {
                return NotFound();
            }

            return reporttables;
        }

        [HttpPost]
        public async Task<ActionResult<Reporttables>> PostReporttables(Reporttables reporttables)
        {
            _context.reporttables.Add(reporttables);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReporttables", new { id = reporttables.id }, reporttables);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReporttables(int id, Reporttables reporttables)
        {
            if (id != reporttables.id)
            {
                return BadRequest();
            }

            _context.Entry(reporttables).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReporttablesExists(id))
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
        public async Task<IActionResult> DeleteReporttables(int id)
        {
            var reporttables = await _context.reporttables.FindAsync(id);
            if (reporttables == null)
            {
                return NotFound();
            }

            _context.reporttables.Remove(reporttables);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReporttablesExists(int id)
        {
            return _context.reporttables.Any(e => e.id == id);
        }
    }
}