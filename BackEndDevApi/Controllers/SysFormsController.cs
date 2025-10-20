using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysFormsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public SysFormsController(BackEndDbContext context)
        {
            _context = context;
        }

        // GET: api/SysForms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysForms>>> GetSysForms()
        {
            return await _context.sysforms.ToListAsync();
        }

        // GET: api/SysForms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SysForms>> GetSysForms(int id)
        {
            var sysForms = await _context.sysforms.FindAsync(id);

            if (sysForms == null)
            {
                return NotFound();
            }

            return sysForms;
        }

        // PUT: api/SysForms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysForms(int id, SysForms sysForms)
        {
            if (id != sysForms.formid)
            {
                return BadRequest();
            }

            _context.Entry(sysForms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysFormsExists(id))
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

        // POST: api/SysForms
        [HttpPost]
        public async Task<ActionResult<SysForms>> PostSysForms(SysForms sysForms)
        {
            _context.sysforms.Add(sysForms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysForms", new { id = sysForms.formid }, sysForms);
        }

        // DELETE: api/SysForms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysForms(int id)
        {
            var sysForms = await _context.sysforms.FindAsync(id);
            if (sysForms == null)
            {
                return NotFound();
            }

            _context.sysforms.Remove(sysForms);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysFormsExists(int id)
        {
            return _context.sysforms.Any(e => e.formid == id);
        }
    }
}