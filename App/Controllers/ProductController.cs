using DAL.Repository;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
	[Route("ProductList")]
	public class ProductController : Controller
	{
		private readonly IProductRepo<Product> _productRepo;

		public ProductController(IProductRepo<Product> productRepo)
		{
			this._productRepo = productRepo;
		}

		//[Route("/")]
		[Route("List", Name = "List")]
		public IActionResult ProductList()
		{
			var ps = _productRepo.GetAllProducts();
			return View(ps);
		}

		[Route("ADD", Name = "Add")]
		public IActionResult AddProduct()
		{

			return View();
		}
		[HttpPost]
		[Route("ADD", Name = "Adds")]
		public IActionResult AddProduct(Product ps)
		{
			var events = _productRepo.AddProduct(ps);
			return RedirectToAction("ProductList");
		}

		[Route("EDIT/{id}", Name = "update")]
		public IActionResult UpdateProduct(int id)
		{
			var i = _productRepo.GetProductById(id);
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
		[Route("EDIT", Name = "edits")]
		public IActionResult UpdateProduct(Product prt)
		{
			if (prt != null)
			{
				_productRepo.UpdateProduct(prt);
				return RedirectToAction("ProductList");
			}
			else
			{
				return NotFound();
			}
		}
		[Route("Delete/{id}", Name = "delete")]
		public IActionResult DeleteProduct(int id)
		{
			var i = _productRepo.GetProductById(id);
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
		[Route("Delete", Name = "deletes")]
		public IActionResult DeleteProduct(Product pdt)
		{
			if (pdt != null)
			{
				_productRepo.RemoveProduct(pdt);
				return RedirectToAction("ProductList");
			}
			else
			{
				return NotFound();
			}
		}
		[Route("Details", Name = "details")]
		public IActionResult ProductDetails(int id)
		{
			var i = _productRepo.GetProductById(id);
			return View(i);
		}
	}
}
