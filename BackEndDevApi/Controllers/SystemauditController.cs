using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SystemauditController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public SystemauditController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Systemaudit>> GetSystemaudit()
		{
			return _backEndDbContext.systemaudit;
		}

		[HttpGet("{aid_}")]
		public ActionResult<Systemaudit> GetSystemauditById(int aid_)
		{
			return _backEndDbContext.systemaudit.Where(x => x.aid == aid_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Systemaudit systemaudit)
		{
			await _backEndDbContext.systemaudit.AddAsync(systemaudit);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Systemaudit systemaudit)
		{
			_backEndDbContext.systemaudit.Update(systemaudit);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(int aid)
		{
			var systemauditById = GetSystemauditById(aid);
			if (systemauditById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(systemauditById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}