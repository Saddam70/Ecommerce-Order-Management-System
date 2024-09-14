using DAL.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public class ProductRepo : IProductRepo<Product>
	{
		public Product AddProduct(Product product)
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				dbContext.Products.Add(product);
				dbContext.SaveChanges();
				return product;
			}
		}

		public List<Product> GetAllProducts()
		{

			using (EcomDbContext dbContext = new EcomDbContext())
			{
				var products = dbContext.Products.ToList();
				return products;
			}
		}

		public Product GetProductById(int id)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingproduct = ctx.Products.Where(e => e.ProductId.Equals(id)).FirstOrDefault();
				return existingproduct;
			}
		}

		public Product RemoveProduct(Product product)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				ctx.Products.Remove(product);
				ctx.SaveChanges();
				return product;
			}
		}

		public Product UpdateProduct(Product product)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingProduct = ctx.Products.Where(e => e.ProductId.Equals(product.ProductId)).FirstOrDefault();
				existingProduct.ProductName = product.ProductName;
				existingProduct.Category = product.Category;
				existingProduct.ListPrice = product.ListPrice;
				ctx.SaveChanges();
				return existingProduct;
			}
		}
	}
}
