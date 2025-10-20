using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArCreditDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public ArCreditDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArCreditDetails>>> Getar_credit_details()
        {
            return await _context.ar_credit_details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArCreditDetails>> GetArCreditDetails(int id)
        {
            var arCreditDetails = await _context.ar_credit_details.FindAsync(id);

            if (arCreditDetails == null)
            {
                return NotFound();
            }

            return arCreditDetails;
        }

        [HttpPost]
        public async Task<ActionResult<ArCreditDetails>> PostArCreditDetails(ArCreditDetails arCreditDetails)
        {
            _context.ar_credit_details.Add(arCreditDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArCreditDetails", new { id = arCreditDetails.rdid }, arCreditDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutArCreditDetails(int id, ArCreditDetails arCreditDetails)
        {
            if (id != arCreditDetails.rdid)
            {
                return BadRequest();
            }

            _context.Entry(arCreditDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArCreditDetailsExists(id))
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
        public async Task<IActionResult> DeleteArCreditDetails(int id)
        {
            var arCreditDetails = await _context.ar_credit_details.FindAsync(id);
            if (arCreditDetails == null)
            {
                return NotFound();
            }

            _context.ar_credit_details.Remove(arCreditDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArCreditDetailsExists(int id)
        {
            return _context.ar_credit_details.Any(e => e.rdid == id);
        }
    }
}