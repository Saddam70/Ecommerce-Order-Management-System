using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public class OrderItemRepo : IOrderItemRepo<OrderItem>
	{
		public OrderItem AddOrderItem(OrderItem c)
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				dbContext.orderItems.Add(c);
				dbContext.SaveChanges();
				return c;
			}
		}

		public List<OrderItem> GetAllItem()
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				var ord = dbContext.orderItems.ToList();
				return ord;
			}
		}

		public OrderItem GetItemById(int id)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingord = ctx.orderItems.Where(e => e.OrderItemId.Equals(id)).FirstOrDefault();
				return existingord;
			}
		}

		public OrderItem RemoveItem(OrderItem o)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				ctx.orderItems.Remove(o);
				ctx.SaveChanges();
				return o;
			}
		}

		public OrderItem UpdateItem(OrderItem c)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingord = ctx.orderItems.Where(e => e.OrderItemId.Equals(c.OrderItemId)).FirstOrDefault();
				existingord.Quantity = c.Quantity;
				existingord.SalesPrice = c.SalesPrice;
				existingord.TotalAmount = c.TotalAmount;
				
				ctx.SaveChanges();
				return existingord;
			}
		}
	}
}
