using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;

		public CategController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Categ>> Getcateg()
		{
			var list = _backEndDbContext.sc.ToList();
			return Ok(new ApiResponse<Categ>
			{
				result = true,
				message = "Fetched all categories",
				data = list
			});
		}

		[HttpGet("{code}")]
		public ActionResult<Categ> GetCategById(string code)
		{
			var item = _backEndDbContext.sc.Where(x => x.code == code).SingleOrDefault();
			if (item == null)
			{
				return NotFound(new ApiResponse<Categ>
				{
					result = false,
					message = "Category not found",
					data = new List<Categ>()
				});
			}

			return Ok(new ApiResponse<Categ>
			{
				result = true,
				message = "Category found",
				data = new List<Categ> { item }
			});
		}

		[HttpPost]
		public async Task<ActionResult> Create(Categ sc)
		{
			await _backEndDbContext.sc.AddAsync(sc);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Categ>
			{
				result = true,
				message = "Category created",
				data = new List<Categ> { sc }
			});
		}

		[HttpPut]
		public async Task<ActionResult> Update(Categ sc)
		{
			_backEndDbContext.sc.Update(sc);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Categ>
			{
				result = true,
				message = "Category updated",
				data = new List<Categ> { sc }
			});
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var Categgetbyid = GetCategById(code);
			if (Categgetbyid.Value is null)
				return NotFound(new ApiResponse<Categ>
				{
					result = false,
					message = "Category not found",
					data = new List<Categ>()
				});

			_backEndDbContext.Remove(Categgetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<Categ>
			{
				result = true,
				message = "Category deleted",
				data = new List<Categ> { Categgetbyid.Value }
			});
		}
	}
}
