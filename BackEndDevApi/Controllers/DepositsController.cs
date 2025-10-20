using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepositsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public DepositsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deposits>>> Getdeposits()
        {
            return await _context.deposits.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Deposits>> GetDeposits(int id)
        {
            var deposits = await _context.deposits.FindAsync(id);

            if (deposits == null)
            {
                return NotFound();
            }

            return deposits;
        }

        [HttpPost]
        public async Task<ActionResult<Deposits>> PostDeposits(Deposits deposits)
        {
            _context.deposits.Add(deposits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeposits", new { id = deposits.id }, deposits);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeposits(int id, Deposits deposits)
        {
            if (id != deposits.id)
            {
                return BadRequest();
            }

            _context.Entry(deposits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepositsExists(id))
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
        public async Task<IActionResult> DeleteDeposits(int id)
        {
            var deposits = await _context.deposits.FindAsync(id);
            if (deposits == null)
            {
                return NotFound();
            }

            _context.deposits.Remove(deposits);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepositsExists(int id)
        {
            return _context.deposits.Any(e => e.id == id);
        }
    }
}