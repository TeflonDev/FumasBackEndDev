using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CashoutController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public CashoutController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Cashout>> GetCashout()
		{
			return _backEndDbContext.cashout;
		}

		[HttpGet("{refno_}")]
		public ActionResult<Cashout> GetCashoutById(string refno_)
		{
			return _backEndDbContext.cashout.Where(x => x.refno == refno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Cashout cashout)
		{
			await _backEndDbContext.cashout.AddAsync(cashout);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Cashout cashout)
		{
			_backEndDbContext.cashout.Update(cashout);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string refno)
		{
			var cashoutById = GetCashoutById(refno);
			if (cashoutById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(cashoutById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}