using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankReconEntriesController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public BankReconEntriesController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/BankReconEntries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankReconEntries>>> GetBankReconEntries()
        {
            return await _context.bankreconentries.ToListAsync();
        }

        // GET: api/BankReconEntries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankReconEntries>> GetBankReconEntries(int id)
        {
            var bankReconEntry = await _context.bankreconentries.FindAsync(id);

            if (bankReconEntry == null)
            {
                return NotFound();
            }

            return bankReconEntry;
        }

        // PUT: api/BankReconEntries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankReconEntries(int id, BankReconEntries bankReconEntries)
        {
            if (id != bankReconEntries.brid)
            {
                return BadRequest();
            }

            _context.Entry(bankReconEntries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankReconEntriesExists(id))
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

        // POST: api/BankReconEntries
        [HttpPost]
        public async Task<ActionResult<BankReconEntries>> PostBankReconEntries(BankReconEntries bankReconEntries)
        {
            _context.bankreconentries.Add(bankReconEntries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankReconEntries", new { id = bankReconEntries.brid }, bankReconEntries);
        }

        // DELETE: api/BankReconEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankReconEntries(int id)
        {
            var bankReconEntry = await _context.bankreconentries.FindAsync(id);
            if (bankReconEntry == null)
            {
                return NotFound();
            }

            _context.bankreconentries.Remove(bankReconEntry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankReconEntriesExists(int id)
        {
            return _context.bankreconentries.Any(e => e.brid == id);
        }
    }
}