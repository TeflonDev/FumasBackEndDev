using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PosDetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public PosDetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PosDetails>>> Getpos_details()
        {
            return await _context.pos_details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PosDetails>> GetPosDetails(int id)
        {
            var posDetails = await _context.pos_details.FindAsync(id);

            if (posDetails == null)
            {
                return NotFound();
            }

            return posDetails;
        }

        [HttpPost]
        public async Task<ActionResult<PosDetails>> PostPosDetails(PosDetails posDetails)
        {
            _context.pos_details.Add(posDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosDetails", new { id = posDetails.posdid }, posDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosDetails(int id, PosDetails posDetails)
        {
            if (id != posDetails.posdid)
            {
                return BadRequest();
            }

            _context.Entry(posDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosDetailsExists(id))
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
        public async Task<IActionResult> DeletePosDetails(int id)
        {
            var posDetails = await _context.pos_details.FindAsync(id);
            if (posDetails == null)
            {
                return NotFound();
            }

            _context.pos_details.Remove(posDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PosDetailsExists(int id)
        {
            return _context.pos_details.Any(e => e.posdid == id);
        }
    }
}