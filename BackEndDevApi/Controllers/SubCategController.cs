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

		[HttpPut("{code}")]
		public async Task<ActionResult> Update(string code, SubCateg sub_sc)
		{
			var entity = _backEndDbContext.sub_sc.FirstOrDefault(x => x.code == code);
			if (entity == null)
			{
				return NotFound(new ApiResponse<SubCateg>
				{
					result = false,
					message = "Subcategory not found",
					data = new List<SubCateg>()
				 });
			}

			if (code == sub_sc.code)
			{
				// Update only the fields that are different and not null in sub_sc
				if (sub_sc.descr != null && sub_sc.descr != entity.descr) entity.descr = sub_sc.descr;
				if (sub_sc.lastprice.HasValue && sub_sc.lastprice != entity.lastprice) entity.lastprice = sub_sc.lastprice;
				if (sub_sc.wholesale.HasValue && sub_sc.wholesale != entity.wholesale) entity.wholesale = sub_sc.wholesale;
				if (sub_sc.sellingprice.HasValue && sub_sc.sellingprice != entity.sellingprice) entity.sellingprice = sub_sc.sellingprice;
				if (sub_sc.main_categ != null && sub_sc.main_categ != entity.main_categ) entity.main_categ = sub_sc.main_categ;
				if (sub_sc.clist.HasValue && sub_sc.clist != entity.clist) entity.clist = sub_sc.clist;
				if (sub_sc.yy.HasValue && sub_sc.yy != entity.yy) entity.yy = sub_sc.yy;
				if (sub_sc.pp.HasValue && sub_sc.pp != entity.pp) entity.pp = sub_sc.pp;
				if (sub_sc.id.HasValue && sub_sc.id != entity.id) entity.id = sub_sc.id;

				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<SubCateg>
				{
					result = true,
					message = "Subcategory updated",
					data = new List<SubCateg> { entity }
				});
			}
			else
			{
				// Key is changed: create new entity, copy changed fields, remove old
				var newEntity = new SubCateg
				{
					code = sub_sc.code,
					descr = sub_sc.descr ?? entity.descr,
					lastprice = sub_sc.lastprice ?? entity.lastprice,
					wholesale = sub_sc.wholesale ?? entity.wholesale,
					sellingprice = sub_sc.sellingprice ?? entity.sellingprice,
					main_categ = sub_sc.main_categ ?? entity.main_categ,
					clist = sub_sc.clist ?? entity.clist,
					yy = sub_sc.yy ?? entity.yy,
					pp = sub_sc.pp ?? entity.pp,
					id = sub_sc.id ?? entity.id
				};

				_backEndDbContext.sub_sc.Remove(entity);
				await _backEndDbContext.sub_sc.AddAsync(newEntity);
				await _backEndDbContext.SaveChangesAsync();

				return Ok(new ApiResponse<SubCateg>
				{
					result = true,
					message = "Subcategory key and/or fields updated",
					data = new List<SubCateg> { newEntity }
				});
			}
		}

		[HttpDelete("{code}")]
		public async Task<ActionResult> Delete(string code)
		{
			var entity = _backEndDbContext.sub_sc.FirstOrDefault(x => x.code == code);
			if (entity == null)
				return NotFound(new ApiResponse<SubCateg>
				{
					result = false,
					message = "Subcategory not found",
					data = new List<SubCateg>()
				});

			_backEndDbContext.sub_sc.Remove(entity);
			await _backEndDbContext.SaveChangesAsync();

			return Ok(new ApiResponse<SubCateg>
			{
				result = true,
				message = "Subcategory deleted",
				data = new List<SubCateg> { entity }
			});
		}
	}
}
