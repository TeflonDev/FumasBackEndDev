using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public JournalDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JournalDetails>>> Getjournal_details()
        {
            return await _context.journal_details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JournalDetails>> GetJournalDetails(int id)
        {
            var journalDetails = await _context.journal_details.FindAsync(id);

            if (journalDetails == null)
            {
                return NotFound();
            }

            return journalDetails;
        }

        [HttpPost]
        public async Task<ActionResult<JournalDetails>> PostJournalDetails(JournalDetails journalDetails)
        {
            _context.journal_details.Add(journalDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJournalDetails", new { id = journalDetails.jtid }, journalDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournalDetails(int id, JournalDetails journalDetails)
        {
            if (id != journalDetails.jtid)
            {
                return BadRequest();
            }

            _context.Entry(journalDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalDetailsExists(id))
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
        public async Task<IActionResult> DeleteJournalDetails(int id)
        {
            var journalDetails = await _context.journal_details.FindAsync(id);
            if (journalDetails == null)
            {
                return NotFound();
            }

            _context.journal_details.Remove(journalDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JournalDetailsExists(int id)
        {
            return _context.journal_details.Any(e => e.jtid == id);
        }
    }
}