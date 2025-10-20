using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApPrepaymentController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public ApPrepaymentController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ApPrepayment>> GetApPrepayment()
		{
			return _backEndDbContext.ap_prepayment;
		}

		[HttpGet("{pno_}")]
		public ActionResult<ApPrepayment> GetApPrepaymentById(string pno_)
		{
			return _backEndDbContext.ap_prepayment.Where(x => x.pno == pno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(ApPrepayment apPrepayment)
		{
			await _backEndDbContext.ap_prepayment.AddAsync(apPrepayment);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(ApPrepayment apPrepayment)
		{
			_backEndDbContext.ap_prepayment.Update(apPrepayment);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string pno)
		{
			var apPrepaymentById = GetApPrepaymentById(pno);
			if (apPrepaymentById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(apPrepaymentById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}