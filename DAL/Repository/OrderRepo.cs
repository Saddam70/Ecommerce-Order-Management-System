using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public class OrderRepo : IOrderRepo<Order>
	{
		public Order AddOrder(Order c)
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				dbContext.Orders.Add(c);
				dbContext.SaveChanges();
				return c;
			}
		}

		public List<Order> GetAllOrder()
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				var ord = dbContext.Orders.ToList();
				return ord;
			}
		}

		public Order GetOrderById(int id)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingord = ctx.Orders.Where(e => e.OrderId.Equals(id)).FirstOrDefault();
				return existingord;
			}
		}

		public Order RemoveOrder(Order id)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				ctx.Orders.Remove(id);
				ctx.SaveChanges();
				return id;
			}
		}

		public Order UpdateOrder(Order c)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingord = ctx.Orders.Where(e => e.OrderId.Equals(c.OrderId)).FirstOrDefault();
				existingord.OrderDate = c.OrderDate;
				existingord.ProductId = c.ProductId;
				existingord.CustomerId = c.CustomerId;

				ctx.SaveChanges();
				return existingord;
			}
		}
	}
}
