using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AutosettingsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public AutosettingsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Autosettings>> GetAutosettings()
		{
			return _backEndDbContext.autosettings;
		}

		[HttpGet("{id_}")]
		public ActionResult<Autosettings> GetAutosettingsById(int id_)
		{
			return _backEndDbContext.autosettings.Where(x => x.id == id_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Autosettings autosettings)
		{
			await _backEndDbContext.autosettings.AddAsync(autosettings);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Autosettings autosettings)
		{
			_backEndDbContext.autosettings.Update(autosettings);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(int id)
		{
			var autosettingsById = GetAutosettingsById(id);
			if (autosettingsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(autosettingsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}