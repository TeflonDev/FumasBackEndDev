using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public UsersController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Users>> Getusers()
		{
			return _backEndDbContext.users;
		}

	

		[HttpGet("{code_}")]
		public ActionResult<Users> GetUsersById(string code_)
		{
			return _backEndDbContext.users.Where(x => x.usercode == code_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Users users)
		{
			await _backEndDbContext.users.AddAsync(users);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
			//return CreatedAtAction(nameof(GetClientById), client);//hii inashow product location/url kwa api
		}
		[HttpPut]
		public async Task<ActionResult> Update(Users users)
		{
			_backEndDbContext.users.Update(users);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
		[HttpDelete]
		public async Task<ActionResult> Delete(string usercode)
		{
			var Usersgetbyid = GetUsersById(usercode);
			if (Usersgetbyid.Value is null)
				return NotFound();
			_backEndDbContext.Remove(Usersgetbyid.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}
