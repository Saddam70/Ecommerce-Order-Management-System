using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DAL.Models
{
	public class EcomDbContext : DbContext
	{
		//To declare prop. of type DbSet<Entity>
		

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<OrderItem> orderItems { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//It contains details about connection string
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(DatabaseHelper.GetConnectionString());
			}

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//It contains configuration of entities in form of fluent api

			//one-To-Many

			modelBuilder.Entity<Order>().HasOne<Product>().WithMany().HasForeignKey(cust => cust.ProductId);
			modelBuilder.Entity<Order>().HasOne<Customer>().WithMany().HasForeignKey(cust => cust.CustomerId);
			modelBuilder.Entity<OrderItem>().HasOne<Order>().WithMany().HasForeignKey(order => order.OrderId);
			modelBuilder.Entity<OrderItem>().HasOne<Product>().WithMany().HasForeignKey(order => order.ProductId);
			modelBuilder.Entity<Customer>().HasKey(cust => cust.CustomerId);
			;
			//Seed Data for default admin
			//modelBuilder.Entity<AdminInfo>().HasData(
			//	new AdminInfo { EmailId = "admin@gmail.com", Password = "admin123", Role = "Admin" }
			//	);

			base.OnModelCreating(modelBuilder);
		}
	}
}
