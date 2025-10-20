using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BankTransferController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public BankTransferController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<BankTransfer>> GetBankTransfer()
		{
			return _backEndDbContext.bank_transfer;
		}

		[HttpGet("{code_}")]
		public ActionResult<BankTransfer> GetBankTransferById(string code_)
		{
			return _backEndDbContext.bank_transfer.Where(x => x.code == code_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(BankTransfer bankTransfer)
		{
			await _backEndDbContext.bank_transfer.AddAsync(bankTransfer);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(BankTransfer bankTransfer)
		{
			_backEndDbContext.bank_transfer.Update(bankTransfer);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var bankTransferById = GetBankTransferById(code);
			if (bankTransferById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(bankTransferById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}