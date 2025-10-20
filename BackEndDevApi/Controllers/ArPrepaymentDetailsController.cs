using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArPrepaymentDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ArPrepaymentDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArPrepaymentDetails>>> Getar_prepayment_details()
        {
            return await _context.ar_prepayment_details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArPrepaymentDetails>> GetArPrepaymentDetails(int id)
        {
            var arPrepaymentDetails = await _context.ar_prepayment_details.FindAsync(id);

            if (arPrepaymentDetails == null)
            {
                return NotFound();
            }

            return arPrepaymentDetails;
        }

        [HttpPost]
        public async Task<ActionResult<ArPrepaymentDetails>> PostArPrepaymentDetails(ArPrepaymentDetails arPrepaymentDetails)
        {
            _context.ar_prepayment_details.Add(arPrepaymentDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArPrepaymentDetails", new { id = arPrepaymentDetails.rdid }, arPrepaymentDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutArPrepaymentDetails(int id, ArPrepaymentDetails arPrepaymentDetails)
        {
            if (id != arPrepaymentDetails.rdid)
            {
                return BadRequest();
            }

            _context.Entry(arPrepaymentDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArPrepaymentDetailsExists(id))
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
        public async Task<IActionResult> DeleteArPrepaymentDetails(int id)
        {
            var arPrepaymentDetails = await _context.ar_prepayment_details.FindAsync(id);
            if (arPrepaymentDetails == null)
            {
                return NotFound();
            }

            _context.ar_prepayment_details.Remove(arPrepaymentDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArPrepaymentDetailsExists(int id)
        {
            return _context.ar_prepayment_details.Any(e => e.rdid == id);
        }
    }
}