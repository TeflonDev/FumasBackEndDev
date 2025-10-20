using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApprovalsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ApprovalsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Approvals>>> Getapprovals()
        {
            return await _context.approvals.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Approvals>> GetApprovals(int id)
        {
            var approvals = await _context.approvals.FindAsync(id);

            if (approvals == null)
            {
                return NotFound();
            }

            return approvals;
        }

        [HttpPost]
        public async Task<ActionResult<Approvals>> PostApprovals(Approvals approvals)
        {
            _context.approvals.Add(approvals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApprovals", new { id = approvals.id }, approvals);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApprovals(int id, Approvals approvals)
        {
            if (id != approvals.id)
            {
                return BadRequest();
            }

            _context.Entry(approvals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApprovalsExists(id))
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
        public async Task<IActionResult> DeleteApprovals(int id)
        {
            var approvals = await _context.approvals.FindAsync(id);
            if (approvals == null)
            {
                return NotFound();
            }

            _context.approvals.Remove(approvals);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApprovalsExists(int id)
        {
            return _context.approvals.Any(e => e.id == id);
        }
    }
}