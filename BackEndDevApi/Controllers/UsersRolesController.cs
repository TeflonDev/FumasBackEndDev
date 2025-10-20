using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersRolesController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public UsersRolesController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<UsersRoles>> GetUsersRoles()
		{
			return _backEndDbContext.users_roles;
		}

		[HttpGet("{role_name_}")]
		public ActionResult<UsersRoles> GetUsersRolesById(string role_name_)
		{
			return _backEndDbContext.users_roles.Where(x => x.role_name == role_name_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(UsersRoles usersRoles)
		{
			await _backEndDbContext.users_roles.AddAsync(usersRoles);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(UsersRoles usersRoles)
		{
			_backEndDbContext.users_roles.Update(usersRoles);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string role_name)
		{
			var usersRolesById = GetUsersRolesById(role_name);
			if (usersRolesById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(usersRolesById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}