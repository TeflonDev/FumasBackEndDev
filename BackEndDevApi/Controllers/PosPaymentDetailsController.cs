using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosPaymentDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public PosPaymentDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/PosPaymentDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PosPaymentDetails>>> GetPosPaymentDetails()
        {
            return await _context.pospaymentdetails.ToListAsync();
        }

        // GET: api/PosPaymentDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PosPaymentDetails>> GetPosPaymentDetails(int id)
        {
            var posPaymentDetail = await _context.pospaymentdetails.FindAsync(id);

            if (posPaymentDetail == null)
            {
                return NotFound();
            }

            return posPaymentDetail;
        }

        // PUT: api/PosPaymentDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosPaymentDetails(int id, PosPaymentDetails posPaymentDetails)
        {
            if (id != posPaymentDetails.paymentid)
            {
                return BadRequest();
            }

            _context.Entry(posPaymentDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosPaymentDetailsExists(id))
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

        // POST: api/PosPaymentDetails
        [HttpPost]
        public async Task<ActionResult<PosPaymentDetails>> PostPosPaymentDetails(PosPaymentDetails posPaymentDetails)
        {
            _context.pospaymentdetails.Add(posPaymentDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosPaymentDetails", new { id = posPaymentDetails.paymentid }, posPaymentDetails);
        }

        // DELETE: api/PosPaymentDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosPaymentDetails(int id)
        {
            var posPaymentDetail = await _context.pospaymentdetails.FindAsync(id);
            if (posPaymentDetail == null)
            {
                return NotFound();
            }

            _context.pospaymentdetails.Remove(posPaymentDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PosPaymentDetailsExists(int id)
        {
            return _context.pospaymentdetails.Any(e => e.paymentid == id);
        }
    }
}