using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GrnController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public GrnController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Grn>> GetGrn()
		{
			return _backEndDbContext.grn;
		}

		[HttpGet("{no_}")]
		public ActionResult<Grn> GetGrnById(string no_)
		{
			return _backEndDbContext.grn.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Grn grn)
		{
			await _backEndDbContext.grn.AddAsync(grn);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Grn grn)
		{
			_backEndDbContext.grn.Update(grn);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var grnById = GetGrnById(no);
			if (grnById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(grnById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}