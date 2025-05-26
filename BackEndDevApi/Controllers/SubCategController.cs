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
			var list = _backEndDbContext.sub_sc.ToList();
			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Fetched all subcategories",
				data = list
			});
		}

		[HttpGet("{code}")]
		public ActionResult<SubCateg> GetSubCategById(string code)
		{
			var item = _backEndDbContext.sub_sc.Where(x => x.code == code).SingleOrDefault();
			if (item == null)
			{
				return NotFound(new ApiResponse<SubCateg>
				{
					result = false,
					message = "Subcategory not found",
					data = new List<SubCateg>()
				});
			}

			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Subcategory found",
				data = new List<SubCateg> { item }
			});
		}

		[HttpPost]
		public async Task<ActionResult> Create(SubCateg sub_sc)
		{
			await _backEndDbContext.sub_sc.AddAsync(sub_sc);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Subcategory created",
				data = new List<SubCateg> { sub_sc }
			});
		}

		[HttpPut]
		public async Task<ActionResult> Update(SubCateg sub_sc)
		{
			_backEndDbContext.sub_sc.Update(sub_sc);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Subcategory updated",
				data = new List<SubCateg> { sub_sc }
			});
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var SubCateggetbyid = GetSubCategById(code);
			if (SubCateggetbyid.Value is null)
				return NotFound(new ApiResponse<SubCateg>
				{
					result = false,
					message = "Subcategory not found",
					data = new List<SubCateg>()
				});

			_backEndDbContext.Remove(SubCateggetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Subcategory deleted",
				data = new List<SubCateg> { SubCateggetbyid.Value }
			});
		}
	}
}
