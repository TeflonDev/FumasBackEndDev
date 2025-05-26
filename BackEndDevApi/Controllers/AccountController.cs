using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public AccountsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Accounts>> Getaccounts()
		{
			return _backEndDbContext.accounts;
		}



		[HttpGet("{code}")]
		public ActionResult<Accounts> GetAccountsById(string code)
		{
			return _backEndDbContext.accounts.Where(x => x.code == code).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Accounts accounts)
		{
			await _backEndDbContext.accounts.AddAsync(accounts);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
			//return CreatedAtAction(nameof(GetClientById), client);//hii inashow product location/url kwa api
		}
		[HttpPut]
		public async Task<ActionResult> Update(Accounts accounts)
		{
			_backEndDbContext.accounts.Update(accounts);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var Accountsgetbyid = GetAccountsById(code);
			if (Accountsgetbyid.Value is null)
				return NotFound();
			_backEndDbContext.Remove(Accountsgetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}
