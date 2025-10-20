using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LpoDController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public LpoDController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LpoD>>> Getlpo_d()
        {
            return await _context.lpo_d.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LpoD>> GetLpoD(int id)
        {
            var lpoD = await _context.lpo_d.FindAsync(id);

            if (lpoD == null)
            {
                return NotFound();
            }

            return lpoD;
        }

        [HttpPost]
        public async Task<ActionResult<LpoD>> PostLpoD(LpoD lpoD)
        {
            _context.lpo_d.Add(lpoD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLpoD", new { id = lpoD.ldid }, lpoD);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLpoD(int id, LpoD lpoD)
        {
            if (id != lpoD.ldid)
            {
                return BadRequest();
            }

            _context.Entry(lpoD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LpoDExists(id))
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
        public async Task<IActionResult> DeleteLpoD(int id)
        {
            var lpoD = await _context.lpo_d.FindAsync(id);
            if (lpoD == null)
            {
                return NotFound();
            }

            _context.lpo_d.Remove(lpoD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LpoDExists(int id)
        {
            return _context.lpo_d.Any(e => e.ldid == id);
        }
    }
}