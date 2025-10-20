using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JournalsController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public JournalsController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Journals>> GetJournals()
		{
			return _backEndDbContext.journals;
		}

		[HttpGet("{code_}")]
		public ActionResult<Journals> GetJournalsById(string code_)
		{
			return _backEndDbContext.journals.Where(x => x.code == code_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Journals journals)
		{
			await _backEndDbContext.journals.AddAsync(journals);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Journals journals)
		{
			_backEndDbContext.journals.Update(journals);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string code)
		{
			var journalsById = GetJournalsById(code);
			if (journalsById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(journalsById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}