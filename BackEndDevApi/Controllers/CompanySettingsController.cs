using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanySettingsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public CompanySettingsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<CompanySettings>> GetCompanySettings()
		{
			return _backEndDbContext.company_settings;
		}

		[HttpGet("{name_}")]
		public ActionResult<CompanySettings> GetCompanySettingsById(string name_)
		{
			return _backEndDbContext.company_settings.Where(x => x.name == name_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(CompanySettings companySettings)
		{
			await _backEndDbContext.company_settings.AddAsync(companySettings);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(CompanySettings companySettings)
		{
			_backEndDbContext.company_settings.Update(companySettings);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string name)
		{
			var companySettingsById = GetCompanySettingsById(name);
			if (companySettingsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(companySettingsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}