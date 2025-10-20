using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CreditController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public CreditController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Credit>> GetCredit()
		{
			return _backEndDbContext.credit;
		}

		[HttpGet("{invno_}")]
		public ActionResult<Credit> GetCreditById(string invno_)
		{
			return _backEndDbContext.credit.Where(x => x.invno == invno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Credit credit)
		{
			await _backEndDbContext.credit.AddAsync(credit);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Credit credit)
		{
			_backEndDbContext.credit.Update(credit);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string invno)
		{
			var creditById = GetCreditById(invno);
			if (creditById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(creditById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}