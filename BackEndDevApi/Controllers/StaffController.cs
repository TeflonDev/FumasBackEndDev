using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;

		public StaffController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Staff>> GetStaff()
		{
			var list = _backEndDbContext.staff.ToList();
			return Ok(new ApiResponse<Staff>
			{
				result = true,
				message = "Fetched all Staff",
				data = list
			});
		}

		[HttpGet("{code}")]
		public ActionResult<Staff> GetStaffById(string code)
		{
			var item = _backEndDbContext.staff.Where(x => x.code == code).SingleOrDefault();
			if (item == null)
			{
				return NotFound(new ApiResponse<Staff>
				{
					result = false,
					message = "Staff not found",
					data = new List<Staff>()
				});
			}

			return Ok(new ApiResponse<Staff>
			{
				result = true,
				message = "Staff found",
				data = new List<Staff> { item }
			});
		}

		[HttpPost]
		public async Task<ActionResult> Create(Staff staff)
		{
			await _backEndDbContext.staff.AddAsync(staff);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Staff>
			{
				result = true,
				message = "Staff created",
				data = new List<Staff> { staff }
			});
		}

		[HttpPut]
		public async Task<ActionResult> Update(Staff staff)
		{
			_backEndDbContext.staff.Update(staff);
			await _backEndDbContext.SaveChangesAsync();
			return Ok(new ApiResponse<Staff>
			{
				result = true,
				message = "Staff updated",
				data = new List<Staff> { staff }
			});
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var entity = _backEndDbContext.staff.FirstOrDefault(x => x.code == code);
			if (entity == null)
				return NotFound(new ApiResponse<Staff>
				{
					result = false,
					message = "Staff not found",
					data = new List<Staff>()
				});

			_backEndDbContext.staff.Remove(entity);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<Staff>
			{
				result = true,
				message = "Staff deleted",
				data = new List<Staff> { entity }
			});
		}
	}
}
