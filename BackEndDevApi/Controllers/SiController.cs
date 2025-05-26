using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SiController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public SiController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<si>> GetItems()
		{
			return _backEndDbContext.si;
		}
	}
}
