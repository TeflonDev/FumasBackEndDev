using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetitemsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public BudgetitemsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Budgetitems>>> Getbudgetitems()
        {
            return await _context.budgetitems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Budgetitems>> GetBudgetitems(int id)
        {
            var budgetitems = await _context.budgetitems.FindAsync(id);

            if (budgetitems == null)
            {
                return NotFound();
            }

            return budgetitems;
        }

        [HttpPost]
        public async Task<ActionResult<Budgetitems>> PostBudgetitems(Budgetitems budgetitems)
        {
            _context.budgetitems.Add(budgetitems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBudgetitems", new { id = budgetitems.id }, budgetitems);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBudgetitems(int id, Budgetitems budgetitems)
        {
            if (id != budgetitems.id)
            {
                return BadRequest();
            }

            _context.Entry(budgetitems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BudgetitemsExists(id))
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
        public async Task<IActionResult> DeleteBudgetitems(int id)
        {
            var budgetitems = await _context.budgetitems.FindAsync(id);
            if (budgetitems == null)
            {
                return NotFound();
            }

            _context.budgetitems.Remove(budgetitems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BudgetitemsExists(int id)
        {
            return _context.budgetitems.Any(e => e.id == id);
        }
    }
}