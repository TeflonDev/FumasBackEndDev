using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueDController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public IssueDController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IssueD>>> Getissue_d()
        {
            return await _context.issue_d.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IssueD>> GetIssueD(int id)
        {
            var issueD = await _context.issue_d.FindAsync(id);

            if (issueD == null)
            {
                return NotFound();
            }

            return issueD;
        }

        [HttpPost]
        public async Task<ActionResult<IssueD>> PostIssueD(IssueD issueD)
        {
            _context.issue_d.Add(issueD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIssueD", new { id = issueD.idid }, issueD);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueD(int id, IssueD issueD)
        {
            if (id != issueD.idid)
            {
                return BadRequest();
            }

            _context.Entry(issueD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueDExists(id))
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
        public async Task<IActionResult> DeleteIssueD(int id)
        {
            var issueD = await _context.issue_d.FindAsync(id);
            if (issueD == null)
            {
                return NotFound();
            }

            _context.issue_d.Remove(issueD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IssueDExists(int id)
        {
            return _context.issue_d.Any(e => e.idid == id);
        }
    }
}