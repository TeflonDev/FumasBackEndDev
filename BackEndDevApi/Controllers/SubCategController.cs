using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubCategController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public SubCategController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<SubCateg>> Getsubcateg()
		{
			return _backEndDbContext.sub_sc;
		}



		[HttpGet("{code}")]
		public ActionResult<SubCateg> GetSubCategById(string code)
		{
			return _backEndDbContext.sub_sc.Where(x => x.code == code).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(SubCateg sub_categ)
		{
			await _backEndDbContext.sub_sc.AddAsync(sub_categ);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
			//return CreatedAtAction(nameof(GetClientById), client);//hii inashow product location/url kwa api
		}
		[HttpPut]
		public async Task<ActionResult> Update(SubCateg sub_categ)
		{
			_backEndDbContext.sub_sc.Update(sub_categ);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var SubCateggetbyid = GetSubCategById(code);
			if (SubCateggetbyid.Value is null)
				return NotFound();
			_backEndDbContext.Remove(SubCateggetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}
