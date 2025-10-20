using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LpoController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public LpoController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Lpo>> GetLpo()
		{
			return _backEndDbContext.lpo;
		}

		[HttpGet("{no_}")]
		public ActionResult<Lpo> GetLpoById(string no_)
		{
			return _backEndDbContext.lpo.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Lpo lpo)
		{
			await _backEndDbContext.lpo.AddAsync(lpo);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Lpo lpo)
		{
			_backEndDbContext.lpo.Update(lpo);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var lpoById = GetLpoById(no);
			if (lpoById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(lpoById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}