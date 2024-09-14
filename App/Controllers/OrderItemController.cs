using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
	public class OrderItemController : Controller
	{
		private readonly IOrderItemRepo<OrderItem> _orderiRepo;

		public OrderItemController(IOrderItemRepo<OrderItem> orderiRepo)
		{
			this._orderiRepo = orderiRepo;
		}
		[Route("orderiList", Name = "orderiList")]
		public IActionResult OrderItemList()
		{
			var ps = _orderiRepo.GetAllItem();
			return View(ps);
		}
	}
}
