using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArReceiptsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public ArReceiptsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ArReceipts>> GetArReceipts()
		{
			return _backEndDbContext.ar_receipts;
		}

		[HttpGet("{rno_}")]
		public ActionResult<ArReceipts> GetArReceiptsById(string rno_)
		{
			return _backEndDbContext.ar_receipts.Where(x => x.rno == rno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(ArReceipts arReceipts)
		{
			await _backEndDbContext.ar_receipts.AddAsync(arReceipts);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(ArReceipts arReceipts)
		{
			_backEndDbContext.ar_receipts.Update(arReceipts);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string rno)
		{
			var arReceiptsById = GetArReceiptsById(rno);
			if (arReceiptsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(arReceiptsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}