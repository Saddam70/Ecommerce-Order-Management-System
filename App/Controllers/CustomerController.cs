using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
	[Route("CustomerList")]
	public class CustomerController : Controller
	{
		private readonly ICustomerRepo<Customer> _cxRepo;

		public CustomerController(ICustomerRepo<Customer> cxRepo)
		{
			this._cxRepo = cxRepo;
		}

		[Route("/")]
		[Route("cxList", Name = "cxList")]
		public IActionResult CustomerList()
		{
			var ps = _cxRepo.GetAllCustomer();
			return View(ps);
		}

		[Route("Addcx", Name = "Addcx")]
		public IActionResult AddCustomer()
		{

			return View();
		}
		[HttpPost]
		[Route("Addcxs", Name = "Addcxs")]
		public IActionResult AddCustomer(Customer cx)
		{
			var cxss = _cxRepo.AddCustomer(cx);
			return RedirectToAction("CustomerList");
		}

		[Route("updatecx/{id}", Name = "updatecx")]
		public IActionResult UpdateCustomer(int id)
		{
			var i = _cxRepo.GetCustomerById(id);
			if (i != null)
			{
				return View(i);
			}
			else
			{
				return NotFound();
			}

		}
		[HttpPost]
		[Route("Editcx", Name = "editcx")]
		public IActionResult UpdateCustomer(Customer cxt)
		{
			if (cxt != null)
			{
				_cxRepo.UpdateCustomer(cxt);
				return RedirectToAction("CustomerList");
			}
			else
			{
				return NotFound();
			}
		}
		[Route("deletecx/{id}", Name = "deletecx")]
		public IActionResult DeleteCustomer(int id)
		{
			var i = _cxRepo.GetCustomerById(id);
			if (i != null)
			{
				return View(i);
			}
			else
			{
				return NotFound();
			}

		}
		[HttpPost]
		[Route("deletecxs", Name = "deletecxs")]
		public IActionResult DeleteCustomer(Customer cxt)
		{
			if (cxt != null)
			{
				_cxRepo.RemoveCustomer(cxt);
				return RedirectToAction("CustomerList");
			}
			else
			{
				return NotFound();
			}
		}
		[Route("detailcx", Name = "detailscx")]
		public IActionResult CustomerDetails(int id)
		{
			var i = _cxRepo.GetCustomerById(id);
			return View(i);
		}
	}
}
