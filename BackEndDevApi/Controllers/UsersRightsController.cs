using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersRightsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public UsersRightsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<UsersRights>> GetUsersRights()
		{
			return _backEndDbContext.users_rights;
		}

		[HttpGet("{usercode_}")]
		public ActionResult<UsersRights> GetUsersRightsById(string usercode_)
		{
			return _backEndDbContext.users_rights.Where(x => x.usercode == usercode_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(UsersRights usersRights)
		{
			await _backEndDbContext.users_rights.AddAsync(usersRights);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(UsersRights usersRights)
		{
			_backEndDbContext.users_rights.Update(usersRights);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string usercode)
		{
			var usersRightsById = GetUsersRightsById(usercode);
			if (usersRightsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(usersRightsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}