using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalTransactionsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public JournalTransactionsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JournalTransactions>>> Getjournal_transactions()
        {
            return await _context.journal_transactions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JournalTransactions>> GetJournalTransactions(int id)
        {
            var journalTransactions = await _context.journal_transactions.FindAsync(id);

            if (journalTransactions == null)
            {
                return NotFound();
            }

            return journalTransactions;
        }

        [HttpPost]
        public async Task<ActionResult<JournalTransactions>> PostJournalTransactions(JournalTransactions journalTransactions)
        {
            _context.journal_transactions.Add(journalTransactions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJournalTransactions", new { id = journalTransactions.jtid }, journalTransactions);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournalTransactions(int id, JournalTransactions journalTransactions)
        {
            if (id != journalTransactions.jtid)
            {
                return BadRequest();
            }

            _context.Entry(journalTransactions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalTransactionsExists(id))
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
        public async Task<IActionResult> DeleteJournalTransactions(int id)
        {
            var journalTransactions = await _context.journal_transactions.FindAsync(id);
            if (journalTransactions == null)
            {
                return NotFound();
            }

            _context.journal_transactions.Remove(journalTransactions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JournalTransactionsExists(int id)
        {
            return _context.journal_transactions.Any(e => e.jtid == id);
        }
    }
}