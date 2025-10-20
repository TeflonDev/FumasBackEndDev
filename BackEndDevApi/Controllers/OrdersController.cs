using BackEndDevApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDevApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly BackEndDbContext _backEndDbContext;
		public OrdersController(BackEndDbContext backEndDbContext)
		{
			_backEndDbContext = backEndDbContext;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Orders>> GetOrders()
		{
			return _backEndDbContext.orders;
		}

		[HttpGet("{invno_}")]
		public ActionResult<Orders> GetOrdersById(string invno_)
		{
			return _backEndDbContext.orders.Where(x => x.invno == invno_).SingleOrDefault();
		}

		[HttpPost]
		public async Task<ActionResult> Create(Orders orders)
		{
			await _backEndDbContext.orders.AddAsync(orders);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Update(Orders orders)
		{
			_backEndDbContext.orders.Update(orders);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(string invno)
		{
			var ordersById = GetOrdersById(invno);
			if (ordersById.Value is null)
				return NotFound();
			_backEndDbContext.Remove(ordersById.Value);
			await _backEndDbContext.SaveChangesAsync();
			return Ok();
		}
	}
}