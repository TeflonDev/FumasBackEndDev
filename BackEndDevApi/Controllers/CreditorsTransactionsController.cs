using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditorsTransactionsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public CreditorsTransactionsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreditorsTransactions>>> Getcreditors_transactions()
        {
            return await _context.creditors_transactions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CreditorsTransactions>> GetCreditorsTransactions(int id)
        {
            var creditorsTransactions = await _context.creditors_transactions.FindAsync(id);

            if (creditorsTransactions == null)
            {
                return NotFound();
            }

            return creditorsTransactions;
        }

        [HttpPost]
        public async Task<ActionResult<CreditorsTransactions>> PostCreditorsTransactions(CreditorsTransactions creditorsTransactions)
        {
            _context.creditors_transactions.Add(creditorsTransactions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreditorsTransactions", new { id = creditorsTransactions.jtid }, creditorsTransactions);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreditorsTransactions(int id, CreditorsTransactions creditorsTransactions)
        {
            if (id != creditorsTransactions.jtid)
            {
                return BadRequest();
            }

            _context.Entry(creditorsTransactions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditorsTransactionsExists(id))
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
        public async Task<IActionResult> DeleteCreditorsTransactions(int id)
        {
            var creditorsTransactions = await _context.creditors_transactions.FindAsync(id);
            if (creditorsTransactions == null)
            {
                return NotFound();
            }

            _context.creditors_transactions.Remove(creditorsTransactions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreditorsTransactionsExists(int id)
        {
            return _context.creditors_transactions.Any(e => e.jtid == id);
        }
    }
}