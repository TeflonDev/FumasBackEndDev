using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosSettingsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public PosSettingsController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/PosSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PosSettings>>> GetPosSettings()
        {
            return await _context.possettings.ToListAsync();
        }

        // GET: api/PosSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PosSettings>> GetPosSettings(int id)
        {
            var posSettings = await _context.possettings.FindAsync(id);

            if (posSettings == null)
            {
                return NotFound();
            }

            return posSettings;
        }

        // PUT: api/PosSettings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosSettings(int id, PosSettings posSettings)
        {
            if (id != posSettings.settingid)
            {
                return BadRequest();
            }

            _context.Entry(posSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosSettingsExists(id))
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

        // POST: api/PosSettings
        [HttpPost]
        public async Task<ActionResult<PosSettings>> PostPosSettings(PosSettings posSettings)
        {
            _context.possettings.Add(posSettings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosSettings", new { id = posSettings.settingid }, posSettings);
        }

        // DELETE: api/PosSettings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosSettings(int id)
        {
            var posSettings = await _context.possettings.FindAsync(id);
            if (posSettings == null)
            {
                return NotFound();
            }

            _context.possettings.Remove(posSettings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PosSettingsExists(int id)
        {
            return _context.possettings.Any(e => e.settingid == id);
        }
    }
}