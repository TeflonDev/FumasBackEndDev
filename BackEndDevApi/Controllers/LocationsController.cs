using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LocationsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;

		public LocationsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Locations>> Getsl()
		{
			var list = _backEndDbContext.sl.ToList();
			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Fetched all Locations",
				data = list
			});
		}

		[HttpGet("{code}")]
		public ActionResult<Locations> GetLocationsById(string code)
		{
			var item = _backEndDbContext.sl.Where(x => x.code == code).SingleOrDefault();
			if (item == null)
			{
				return NotFound(new ApiResponse<Locations>
				{
					result = false,
					message = "Location not found",
					data = new List<Locations>()
				});
			}

			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location found",
				data = new List<Locations	> { item }
			});
		}

		[HttpPost]
		public async Task<ActionResult> Create(Locations sl)
		{
			await _backEndDbContext.sl.AddAsync(sl);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location created",
				data = new List<Locations> { sl }
			});
		}

		[HttpPut]
		public async Task<ActionResult> Update(Locations sl)
		{
			_backEndDbContext.sl.Update(sl);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location updated",
				data = new List<Locations> { sl }
			});
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var Locationsgetbyid = GetLocationsById(code);
			if (Locationsgetbyid.Value is null)
				return NotFound(new ApiResponse<Locations>
				{
					result = false,
					message = "Location not found",
					data = new List<Locations>()
				});

			_backEndDbContext.Remove(Locationsgetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location deleted",
				data = new List<Locations> { Locationsgetbyid.Value }
			});
		}
	}
}
