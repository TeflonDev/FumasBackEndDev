using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApPrepaymentDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ApPrepaymentDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApPrepaymentDetails>>> Getap_prepayment_details()
        {
            return await _context.ap_prepayment_details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApPrepaymentDetails>> GetApPrepaymentDetails(int id)
        {
            var apPrepaymentDetails = await _context.ap_prepayment_details.FindAsync(id);

            if (apPrepaymentDetails == null)
            {
                return NotFound();
            }

            return apPrepaymentDetails;
        }

        [HttpPost]
        public async Task<ActionResult<ApPrepaymentDetails>> PostApPrepaymentDetails(ApPrepaymentDetails apPrepaymentDetails)
        {
            _context.ap_prepayment_details.Add(apPrepaymentDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApPrepaymentDetails", new { id = apPrepaymentDetails.rdid }, apPrepaymentDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApPrepaymentDetails(int id, ApPrepaymentDetails apPrepaymentDetails)
        {
            if (id != apPrepaymentDetails.rdid)
            {
                return BadRequest();
            }

            _context.Entry(apPrepaymentDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApPrepaymentDetailsExists(id))
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
        public async Task<IActionResult> DeleteApPrepaymentDetails(int id)
        {
            var apPrepaymentDetails = await _context.ap_prepayment_details.FindAsync(id);
            if (apPrepaymentDetails == null)
            {
                return NotFound();
            }

            _context.ap_prepayment_details.Remove(apPrepaymentDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApPrepaymentDetailsExists(int id)
        {
            return _context.ap_prepayment_details.Any(e => e.rdid == id);
        }
    }
}