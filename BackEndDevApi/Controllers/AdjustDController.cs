using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdjustDController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public AdjustDController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdjustD>>> Getadjust_d()
        {
            return await _context.adjust_d.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AdjustD>> GetAdjustD(int id)
        {
            var adjustD = await _context.adjust_d.FindAsync(id);

            if (adjustD == null)
            {
                return NotFound();
            }

            return adjustD;
        }

        [HttpPost]
        public async Task<ActionResult<AdjustD>> PostAdjustD(AdjustD adjustD)
        {
            _context.adjust_d.Add(adjustD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdjustD", new { id = adjustD.adid }, adjustD);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdjustD(int id, AdjustD adjustD)
        {
            if (id != adjustD.adid)
            {
                return BadRequest();
            }

            _context.Entry(adjustD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdjustDExists(id))
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
        public async Task<IActionResult> DeleteAdjustD(int id)
        {
            var adjustD = await _context.adjust_d.FindAsync(id);
            if (adjustD == null)
            {
                return NotFound();
            }

            _context.adjust_d.Remove(adjustD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdjustDExists(int id)
        {
            return _context.adjust_d.Any(e => e.adid == id);
        }
    }
}