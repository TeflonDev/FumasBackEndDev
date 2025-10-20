using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosPaymentModeController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public PosPaymentModeController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/PosPaymentMode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PosPaymentMode>>> GetPosPaymentMode()
        {
            return await _context.pospaymentmode.ToListAsync();
        }

        // GET: api/PosPaymentMode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PosPaymentMode>> GetPosPaymentMode(int id)
        {
            var posPaymentMode = await _context.pospaymentmode.FindAsync(id);

            if (posPaymentMode == null)
            {
                return NotFound();
            }

            return posPaymentMode;
        }

        // PUT: api/PosPaymentMode/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosPaymentMode(int id, PosPaymentMode posPaymentMode)
        {
            if (id != posPaymentMode.modeid)
            {
                return BadRequest();
            }

            _context.Entry(posPaymentMode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosPaymentModeExists(id))
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

        // POST: api/PosPaymentMode
        [HttpPost]
        public async Task<ActionResult<PosPaymentMode>> PostPosPaymentMode(PosPaymentMode posPaymentMode)
        {
            _context.pospaymentmode.Add(posPaymentMode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosPaymentMode", new { id = posPaymentMode.modeid }, posPaymentMode);
        }

        // DELETE: api/PosPaymentMode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosPaymentMode(int id)
        {
            var posPaymentMode = await _context.pospaymentmode.FindAsync(id);
            if (posPaymentMode == null)
            {
                return NotFound();
            }

            _context.pospaymentmode.Remove(posPaymentMode);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PosPaymentModeExists(int id)
        {
            return _context.pospaymentmode.Any(e => e.modeid == id);
        }
    }
}