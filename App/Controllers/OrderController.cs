using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderRepo<Order> _orderRepo;

		public OrderController(IOrderRepo<Order> orderRepo)
		{
			this._orderRepo = orderRepo;
		}
		[Route("orderList", Name = "orderList")]
		public IActionResult OrderList()
		{
			var ps = _orderRepo.GetAllOrder();
			return View(ps);
		}
	}
}
