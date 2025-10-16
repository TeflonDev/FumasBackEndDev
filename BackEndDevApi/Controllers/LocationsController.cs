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
				data = new List<Locations> { item }
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

		[HttpPut("{code}")]
		public async Task<ActionResult> Update(string code, Locations sl)
		{
			var entity = _backEndDbContext.sl.FirstOrDefault(x => x.code == code);
			if (entity == null)
			{
				return NotFound(new ApiResponse<Locations>
				{
					result = false,
					message = "Location not found",
					data = new List<Locations>()
				});
			}

			if (code == sl.code)
			{
				// Update only the fields that are different and not null in sl
				if (sl.descr != null && sl.descr != entity.descr) entity.descr = sl.descr;
				if (sl.clist.HasValue && sl.clist != entity.clist) entity.clist = sl.clist;
				if (sl.itemcode != null && sl.itemcode != entity.itemcode) entity.itemcode = sl.itemcode;
				if (sl.itemname != null && sl.itemname != entity.itemname) entity.itemname = sl.itemname;
				if (sl.profitc != null && sl.profitc != entity.profitc) entity.profitc = sl.profitc;
				if (sl.last_updated.HasValue && sl.last_updated != entity.last_updated) entity.last_updated = sl.last_updated;
				if (sl.id.HasValue && sl.id != entity.id) entity.id = sl.id;

				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<Locations>
				{
					result = true,
					message = "Location updated",
					data = new List<Locations> { entity }
				});
			}
			else
			{
				// Key is changed: create new entity, copy changed fields, remove old
				var newEntity = new Locations
				{
					code = sl.code,
					descr = sl.descr ?? entity.descr,
					clist = sl.clist ?? entity.clist,
					itemcode = sl.itemcode ?? entity.itemcode,
					itemname = sl.itemname ?? entity.itemname,
					profitc = sl.profitc ?? entity.profitc,
					last_updated = sl.last_updated ?? entity.last_updated,
					id = sl.id ?? entity.id
				};

				_backEndDbContext.sl.Remove(entity);
				await _backEndDbContext.sl.AddAsync(newEntity);
				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<Locations>
				{
					result = true,
					message = "Location key and/or fields updated",
					data = new List<Locations> { newEntity }
				});
			}
		}

		[HttpPatch("{code}")]
		public async Task<ActionResult> PartialUpdate(string code, Locations sl)
		{
			var entity = _backEndDbContext.sl.FirstOrDefault(x => x.code == code);
			if (entity == null)
			{
				return NotFound(new ApiResponse<Locations>
				{
					result = false,
					message = "Location not found",
					data = new List<Locations>()
				});
			}

			// Update only the fields that are provided and not null in sl
			if (sl.descr != null) entity.descr = sl.descr;
			if (sl.clist.HasValue) entity.clist = sl.clist;
			if (sl.itemcode != null) entity.itemcode = sl.itemcode;
			if (sl.itemname != null) entity.itemname = sl.itemname;
			if (sl.profitc != null) entity.profitc = sl.profitc;
			if (sl.last_updated.HasValue) entity.last_updated = sl.last_updated;
			if (sl.id.HasValue) entity.id = sl.id;

			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location updated",
				data = new List<Locations> { entity }
			});
		}

		[HttpDelete("{code}")]
		public async Task<ActionResult> Delete(string code)
		{
			var entity = _backEndDbContext.sl.FirstOrDefault(x => x.code == code);
			if (entity == null)
				return NotFound(new ApiResponse<Locations>
				{
					result = false,
					message = "Location not found",
					data = new List<Locations>()
				});	

			_backEndDbContext.sl.Remove(entity);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<Locations>
			{
				result = true,
				message = "Location deleted",
				data = new List<Locations> { entity }
			});
		}
	}
}
