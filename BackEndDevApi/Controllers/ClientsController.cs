using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public ClientsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Clients>> GetClients()
		{
			return _backEndDbContext.clients;
		}

		[HttpGet("{code_}")]
		public ActionResult<Clients> GetClientsById(string code_)
		{
			return _backEndDbContext.clients.Where(x => x.code == code_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Clients clients)
		{
			await _backEndDbContext.clients.AddAsync(clients);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Clients clients)
		{
			_backEndDbContext.clients.Update(clients);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var clientsById = GetClientsById(code);
			if (clientsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(clientsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}