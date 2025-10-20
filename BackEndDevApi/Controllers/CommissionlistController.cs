using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommissionlistController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public CommissionlistController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Commissionlist>> GetCommissionlist()
		{
			return _backEndDbContext.commissionlist;
		}

		[HttpGet("{no_}")]
		public ActionResult<Commissionlist> GetCommissionlistById(string no_)
		{
			return _backEndDbContext.commissionlist.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Commissionlist commissionlist)
		{
			await _backEndDbContext.commissionlist.AddAsync(commissionlist);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Commissionlist commissionlist)
		{
			_backEndDbContext.commissionlist.Update(commissionlist);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var commissionlistById = GetCommissionlistById(no);
			if (commissionlistById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(commissionlistById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}