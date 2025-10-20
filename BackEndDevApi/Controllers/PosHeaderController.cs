using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PosHeaderController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public PosHeaderController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<PosHeader>> GetPosHeader()
		{
			return _backEndDbContext.pos_header;
		}

		[HttpGet("{pos_no_}")]
		public ActionResult<PosHeader> GetPosHeaderById(string pos_no_)
		{
			return _backEndDbContext.pos_header.Where(x => x.pos_no == pos_no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(PosHeader posHeader)
		{
			await _backEndDbContext.pos_header.AddAsync(posHeader);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(PosHeader posHeader)
		{
			_backEndDbContext.pos_header.Update(posHeader);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string pos_no)
		{
			var posHeaderById = GetPosHeaderById(pos_no);
			if (posHeaderById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(posHeaderById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}