using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public DetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Details>>> Getdetails()
        {
            return await _context.details.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Details>> GetDetails(int id)
        {
            var details = await _context.details.FindAsync(id);

            if (details == null)
            {
                return NotFound();
            }

            return details;
        }

        [HttpPost]
        public async Task<ActionResult<Details>> PostDetails(Details details)
        {
            _context.details.Add(details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetails", new { id = details.id }, details);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetails(int id, Details details)
        {
            if (id != details.id)
            {
                return BadRequest();
            }

            _context.Entry(details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailsExists(id))
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
        public async Task<IActionResult> DeleteDetails(int id)
        {
            var details = await _context.details.FindAsync(id);
            if (details == null)
            {
                return NotFound();
            }

            _context.details.Remove(details);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetailsExists(int id)
        {
            return _context.details.Any(e => e.id == id);
        }
    }
}