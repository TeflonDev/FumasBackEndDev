using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayrollController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public PayrollController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payroll>>> Getpayroll()
        {
            return await _context.payroll.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payroll>> GetPayroll(int id)
        {
            var payroll = await _context.payroll.FindAsync(id);

            if (payroll == null)
            {
                return NotFound();
            }

            return payroll;
        }

        [HttpPost]
        public async Task<ActionResult<Payroll>> PostPayroll(Payroll payroll)
        {
            _context.payroll.Add(payroll);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayroll", new { id = payroll.id }, payroll);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayroll(int id, Payroll payroll)
        {
            if (id != payroll.id)
            {
                return BadRequest();
            }

            _context.Entry(payroll).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayrollExists(id))
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
        public async Task<IActionResult> DeletePayroll(int id)
        {
            var payroll = await _context.payroll.FindAsync(id);
            if (payroll == null)
            {
                return NotFound();
            }

            _context.payroll.Remove(payroll);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PayrollExists(int id)
        {
            return _context.payroll.Any(e => e.id == id);
        }
    }
}