using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StranController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public StranController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Stran>> GetStran()
		{
			return _backEndDbContext.stran;
		}

		[HttpGet("{code_}")]
		public ActionResult<Stran> GetStranById(string code_)
		{
			return _backEndDbContext.stran.Where(x => x.code == code_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Stran stran)
		{
			await _backEndDbContext.stran.AddAsync(stran);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Stran stran)
		{
			_backEndDbContext.stran.Update(stran);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var stranById = GetStranById(code);
			if (stranById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(stranById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}