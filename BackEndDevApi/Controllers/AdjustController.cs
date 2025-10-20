using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdjustController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public AdjustController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Adjust>> GetAdjust()
		{
			return _backEndDbContext.adjust;
		}

		[HttpGet("{no_}")]
		public ActionResult<Adjust> GetAdjustById(string no_)
		{
			return _backEndDbContext.adjust.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Adjust adjust)
		{
			await _backEndDbContext.adjust.AddAsync(adjust);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Adjust adjust)
		{
			_backEndDbContext.adjust.Update(adjust);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var adjustById = GetAdjustById(no);
			if (adjustById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(adjustById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}