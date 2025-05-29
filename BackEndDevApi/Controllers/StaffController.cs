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

		[HttpPut("{code}")]
		public async Task<ActionResult> Update(string code, Staff staff)
		{
			var entity = _backEndDbContext.staff.FirstOrDefault(x => x.code == code);
			if (entity == null)
			{
				return NotFound(new ApiResponse<Staff>
				{
					result = false,
					message = "Staff not found",
					data = new List<Staff>()
				});
			}

			if (code == staff.code)
			{
				// Update only the fields that are different and not null in staff
				if (staff.names != null && staff.names != entity.names) entity.names = staff.names;
				if (staff.tel1 != null && staff.tel1 != entity.tel1) entity.tel1 = staff.tel1;
				if (staff.tel2 != null && staff.tel2 != entity.tel2) entity.tel2 = staff.tel2;
				if (staff.p_address != null && staff.p_address != entity.p_address) entity.p_address = staff.p_address;
				if (staff.phy_address != null && staff.phy_address != entity.phy_address) entity.phy_address = staff.phy_address;
				if (staff.email != null && staff.email != entity.email) entity.email = staff.email;
				if (staff.dept1 != null && staff.dept1 != entity.dept1) entity.dept1 = staff.dept1;
				if (staff.dept2 != null && staff.dept2 != entity.dept2) entity.dept2 = staff.dept2;
				if (staff.dept3 != null && staff.dept3 != entity.dept3) entity.dept3 = staff.dept3;
				if (staff.dept4 != null && staff.dept4 != entity.dept4) entity.dept4 = staff.dept4;
				if (staff.passport != null && staff.passport != entity.passport) entity.passport = staff.passport;
				if (staff.dl != null && staff.dl != entity.dl) entity.dl = staff.dl;
				if (staff.cellphone != null && staff.cellphone != entity.cellphone) entity.cellphone = staff.cellphone;
				if (staff.w_limit.HasValue && staff.w_limit != entity.w_limit) entity.w_limit = staff.w_limit;
				if (staff.c_limit.HasValue && staff.c_limit != entity.c_limit) entity.c_limit = staff.c_limit;
				if (staff.active.HasValue && staff.active != entity.active) entity.active = staff.active;
				if (staff.cr.HasValue && staff.cr != entity.cr) entity.cr = staff.cr;
				if (staff.cm.HasValue && staff.cm != entity.cm) entity.cm = staff.cm;
				if (staff.country != null && staff.country != entity.country) entity.country = staff.country;
				if (staff.cate != null && staff.cate != entity.cate) entity.cate = staff.cate;
				if (staff.raw_m.HasValue && staff.raw_m != entity.raw_m) entity.raw_m = staff.raw_m;
				if (staff.title != null && staff.title != entity.title) entity.title = staff.title;
				if (staff.department != null && staff.department != entity.department) entity.department = staff.department;
				if (staff.Specialty != null && staff.Specialty != entity.Specialty) entity.Specialty = staff.Specialty;
				if (staff.target.HasValue && staff.target != entity.target) entity.target = staff.target;
				if (staff.licenseno != null && staff.licenseno != entity.licenseno) entity.licenseno = staff.licenseno;
				if (staff.qualified != null && staff.qualified != entity.qualified) entity.qualified = staff.qualified;
				if (staff.dob.HasValue && staff.dob != entity.dob) entity.dob = staff.dob;
				if (staff.dlicence.HasValue && staff.dlicence != entity.dlicence) entity.dlicence = staff.dlicence;
				if (staff.joblevel != null && staff.joblevel != entity.joblevel) entity.joblevel = staff.joblevel;
				if (staff.drivingno != null && staff.drivingno != entity.drivingno) entity.drivingno = staff.drivingno;
				if (staff.usercode != null && staff.usercode != entity.usercode) entity.usercode = staff.usercode;
				if (staff.comlist != null && staff.comlist != entity.comlist) entity.comlist = staff.comlist;

				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<Staff>
				{
					result = true,
					message = "Staff updated",
					data = new List<Staff> { entity }
				});
			}
			else
			{
				// Key is changed: create new entity, copy changed fields, remove old
				var newEntity = new Staff
				{
					cid = entity.cid, // preserve primary key if needed, or let DB assign
					code = staff.code,
					names = staff.names ?? entity.names,
					tel1 = staff.tel1 ?? entity.tel1,
					tel2 = staff.tel2 ?? entity.tel2,
					p_address = staff.p_address ?? entity.p_address,
					phy_address = staff.phy_address ?? entity.phy_address,
					email = staff.email ?? entity.email,
					dept1 = staff.dept1 ?? entity.dept1,
					dept2 = staff.dept2 ?? entity.dept2,
					dept3 = staff.dept3 ?? entity.dept3,
					dept4 = staff.dept4 ?? entity.dept4,
					passport = staff.passport ?? entity.passport,
					dl = staff.dl ?? entity.dl,
					cellphone = staff.cellphone ?? entity.cellphone,
					w_limit = staff.w_limit ?? entity.w_limit,
					c_limit = staff.c_limit ?? entity.c_limit,
					active = staff.active ?? entity.active,
					cr = staff.cr ?? entity.cr,
					cm = staff.cm ?? entity.cm,
					country = staff.country ?? entity.country,
					cate = staff.cate ?? entity.cate,
					raw_m = staff.raw_m ?? entity.raw_m,
					title = staff.title ?? entity.title,
					department = staff.department ?? entity.department,
					Specialty = staff.Specialty ?? entity.Specialty,
					target = staff.target ?? entity.target,
					licenseno = staff.licenseno ?? entity.licenseno,
					qualified = staff.qualified ?? entity.qualified,
					dob = staff.dob ?? entity.dob,
					dlicence = staff.dlicence ?? entity.dlicence,
					joblevel = staff.joblevel ?? entity.joblevel,
					drivingno = staff.drivingno ?? entity.drivingno,
					usercode = staff.usercode ?? entity.usercode,
					comlist = staff.comlist ?? entity.comlist
				};

				_backEndDbContext.staff.Remove(entity);
				await _backEndDbContext.staff.AddAsync(newEntity);
				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<Staff>
				{
					result = true,
					message = "Staff key and/or fields updated",
					data = new List<Staff> { newEntity }
				});
			}
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
