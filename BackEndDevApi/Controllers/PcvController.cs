using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PcvController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public PcvController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Pcv>> GetPcv()
		{
			return _backEndDbContext.pcv;
		}

		[HttpGet("{pno_}")]
		public ActionResult<Pcv> GetPcvById(string pno_)
		{
			return _backEndDbContext.pcv.Where(x => x.pno == pno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Pcv pcv)
		{
			await _backEndDbContext.pcv.AddAsync(pcv);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Pcv pcv)
		{
			_backEndDbContext.pcv.Update(pcv);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string pno)
		{
			var pcvById = GetPcvById(pno);
			if (pcvById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(pcvById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}