using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
	public class CustomerRepo : ICustomerRepo<Customer>
	{
		public Customer AddCustomer(Customer c)
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				dbContext.Customers.Add(c);
				dbContext.SaveChanges();
				return c;
			}
		}

		public List<Customer> GetAllCustomer()
		{
			using (EcomDbContext dbContext = new EcomDbContext())
			{
				var cxs = dbContext.Customers.ToList();
				return cxs;
			}
		}

		public Customer GetCustomerById(int id)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingcx = ctx.Customers.Where(e => e.CustomerId.Equals(id)).FirstOrDefault();
				return existingcx;
			}
		}

		public Customer RemoveCustomer(Customer c)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				ctx.Customers.Remove(c);
				ctx.SaveChanges();
				return c;
			}
		}

		public Customer UpdateCustomer(Customer cx)
		{
			using (EcomDbContext ctx = new EcomDbContext())
			{
				var existingcx = ctx.Customers.Where(e => e.CustomerId.Equals(cx.CustomerId)).FirstOrDefault();
				existingcx.FullName = cx.FullName;
				existingcx.Email = cx.Email;
				existingcx.PhoneNumber = cx.PhoneNumber;
				existingcx.Address = cx.Address;
				ctx.SaveChanges();
				return existingcx;
			}
		}
	}
}
