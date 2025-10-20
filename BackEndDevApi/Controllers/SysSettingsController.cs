using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysSettingsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public SysSettingsController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/SysSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysSettings>>> GetSysSettings()
        {
            return await _context.syssettings.ToListAsync();
        }

        // GET: api/SysSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SysSettings>> GetSysSettings(int id)
        {
            var sysSettings = await _context.syssettings.FindAsync(id);

            if (sysSettings == null)
            {
                return NotFound();
            }

            return sysSettings;
        }

        // PUT: api/SysSettings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysSettings(int id, SysSettings sysSettings)
        {
            if (id != sysSettings.settingid)
            {
                return BadRequest();
            }

            _context.Entry(sysSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysSettingsExists(id))
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

        // POST: api/SysSettings
        [HttpPost]
        public async Task<ActionResult<SysSettings>> PostSysSettings(SysSettings sysSettings)
        {
            _context.syssettings.Add(sysSettings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysSettings", new { id = sysSettings.settingid }, sysSettings);
        }

        // DELETE: api/SysSettings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysSettings(int id)
        {
            var sysSettings = await _context.syssettings.FindAsync(id);
            if (sysSettings == null)
            {
                return NotFound();
            }

            _context.syssettings.Remove(sysSettings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysSettingsExists(int id)
        {
            return _context.syssettings.Any(e => e.settingid == id);
        }
    }
}