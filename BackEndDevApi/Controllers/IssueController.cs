using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IssueController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public IssueController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Issue>> GetIssue()
		{
			return _backEndDbContext.issue;
		}

		[HttpGet("{no_}")]
		public ActionResult<Issue> GetIssueById(string no_)
		{
			return _backEndDbContext.issue.Where(x => x.no == no_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Issue issue)
		{
			await _backEndDbContext.issue.AddAsync(issue);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Issue issue)
		{
			_backEndDbContext.issue.Update(issue);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string no)
		{
			var issueById = GetIssueById(no);
			if (issueById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(issueById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}