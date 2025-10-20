using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrnDController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public GrnDController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrnD>>> Getgrn_d()
        {
            return await _context.grn_d.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GrnD>> GetGrnD(int id)
        {
            var grnD = await _context.grn_d.FindAsync(id);

            if (grnD == null)
            {
                return NotFound();
            }

            return grnD;
        }

        [HttpPost]
        public async Task<ActionResult<GrnD>> PostGrnD(GrnD grnD)
        {
            _context.grn_d.Add(grnD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrnD", new { id = grnD.gdid }, grnD);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrnD(int id, GrnD grnD)
        {
            if (id != grnD.gdid)
            {
                return BadRequest();
            }

            _context.Entry(grnD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrnDExists(id))
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
        public async Task<IActionResult> DeleteGrnD(int id)
        {
            var grnD = await _context.grn_d.FindAsync(id);
            if (grnD == null)
            {
                return NotFound();
            }

            _context.grn_d.Remove(grnD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrnDExists(int id)
        {
            return _context.grn_d.Any(e => e.gdid == id);
        }
    }
}