using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesDdetailsController : ControllerBase
    {
        private readonly BackEndDbContext _context;

        public InvoicesDdetailsController(BackEndDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoicesDdetails>>> Getinvoices_ddetails()
        {
            return await _context.invoices_ddetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoicesDdetails>> GetInvoicesDdetails(int id)
        {
            var invoicesDdetails = await _context.invoices_ddetails.FindAsync(id);

            if (invoicesDdetails == null)
            {
                return NotFound();
            }

            return invoicesDdetails;
        }

        [HttpPost]
        public async Task<ActionResult<InvoicesDdetails>> PostInvoicesDdetails(InvoicesDdetails invoicesDdetails)
        {
            _context.invoices_ddetails.Add(invoicesDdetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoicesDdetails", new { id = invoicesDdetails.idid }, invoicesDdetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoicesDdetails(int id, InvoicesDdetails invoicesDdetails)
        {
            if (id != invoicesDdetails.idid)
            {
                return BadRequest();
            }

            _context.Entry(invoicesDdetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoicesDdetailsExists(id))
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
        public async Task<IActionResult> DeleteInvoicesDdetails(int id)
        {
            var invoicesDdetails = await _context.invoices_ddetails.FindAsync(id);
            if (invoicesDdetails == null)
            {
                return NotFound();
            }

            _context.invoices_ddetails.Remove(invoicesDdetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoicesDdetailsExists(int id)
        {
            return _context.invoices_ddetails.Any(e => e.idid == id);
        }
    }
}