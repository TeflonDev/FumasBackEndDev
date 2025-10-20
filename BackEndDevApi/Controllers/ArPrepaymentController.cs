using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArPrepaymentController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public ArPrepaymentController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ArPrepayment>> GetArPrepayment()
		{
			return _backEndDbContext.ar_prepayment;
		}

		[HttpGet("{pno_}")]
		public ActionResult<ArPrepayment> GetArPrepaymentById(string pno_)
		{
			return _backEndDbContext.ar_prepayment.Where(x => x.pno == pno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(ArPrepayment arPrepayment)
		{
			await _backEndDbContext.ar_prepayment.AddAsync(arPrepayment);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(ArPrepayment arPrepayment)
		{
			_backEndDbContext.ar_prepayment.Update(arPrepayment);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string pno)
		{
			var arPrepaymentById = GetArPrepaymentById(pno);
			if (arPrepaymentById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(arPrepaymentById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}