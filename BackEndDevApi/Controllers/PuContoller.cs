using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDevApi.Data.Entities;

namespace BackEndDevApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuController : ControllerBase // 
    {
        private readonly BackEndDbContext _backEndDbContext;

        public PuController(BackEndDbContext backEndDbContext)
        {
			_backEndDbContext = backEndDbContext;
        }

       
        [HttpGet]
		

		public  ActionResult<IEnumerable<Pu>> GetUnits()
		{
			var list = _backEndDbContext.pu.ToList();
			return Ok(new ApiResponse<Pu>
			{
				result = true,
				message = "Fetched all Packing Units",
				data = list
			});
		}


		[HttpGet("{code}")]
        public ActionResult<Pu> GetUnitByCode(string code)
        {
            var item= _backEndDbContext.pu.Where(x => x.code == code).SingleOrDefault();

			if (item == null)
			{
				return NotFound(new ApiResponse<Pu>
				{
					result = false,
					message = "Packing unit not found",
					data = new List<Pu>()
				});
			}

			return Ok(new ApiResponse<Pu>
			{
				result = true,
				message = "Packing Unit found",
				data = new List<Pu> { item }
			});
		}
        
        
        [HttpPost]
        public async Task<ActionResult<Pu>> AddUnit(Pu pu)
        {
			_backEndDbContext.pu.Add(pu);
            await _backEndDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUnitByCode), new { code = pu.code }, pu);
        }



        [HttpDelete("{code}")]
        public async Task<ActionResult> DeleteUnit(string code)
        {
            var pu = await _backEndDbContext.pu.FirstOrDefaultAsync(p => p.code == code);
            if (pu == null)
                return NotFound();

			_backEndDbContext.pu.Remove(pu);
            await _backEndDbContext.SaveChangesAsync();

            return NoContent();
        }


    }
}

