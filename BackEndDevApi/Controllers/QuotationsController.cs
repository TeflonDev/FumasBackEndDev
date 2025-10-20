using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuotationsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public QuotationsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Quotations>> GetQuotations()
		{
			return _backEndDbContext.quotations;
		}

		[HttpGet("{no_}")]
		public ActionResult<Quotations> GetQuotationsById(string no_)
		{
			return _backEndDbContext.quotations.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Quotations quotations)
		{
			await _backEndDbContext.quotations.AddAsync(quotations);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Quotations quotations)
		{
			_backEndDbContext.quotations.Update(quotations);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var quotationsById = GetQuotationsById(no);
			if (quotationsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(quotationsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}