using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InvoicesController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public InvoicesController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Invoices>> GetInvoices()
		{
			return _backEndDbContext.invoices;
		}

		[HttpGet("{invno_}")]
		public ActionResult<Invoices> GetInvoicesById(string invno_)
		{
			return _backEndDbContext.invoices.Where(x => x.invno == invno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Invoices invoices)
		{
			await _backEndDbContext.invoices.AddAsync(invoices);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Invoices invoices)
		{
			_backEndDbContext.invoices.Update(invoices);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string invno)
		{
			var invoicesById = GetInvoicesById(invno);
			if (invoicesById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(invoicesById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}