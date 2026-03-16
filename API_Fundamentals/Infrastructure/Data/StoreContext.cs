using System.Reflection.Emit;
using API_Fundamentals.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Fundamentals.Infrastructure.Data
{
	public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
	{
		public DbSet<Customer> Customers => Set<Customer>();
		public DbSet<Order> Orders => Set<Order>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure Decimal Precision for SQL Server
			modelBuilder.Entity<Order>()
				.Property(o => o.TotalAmount)
				.HasPrecision(18, 2);

			// 1. Seed 5 Customers
			var customers = new List<Customer>
			{
			new() { Id = 1, Name = "Tech Solutions Inc", Email = "contact@techsolutions.com" },
			new() { Id = 2, Name = "Global Logistics", Email = "info@globallogistics.net" },
			new() { Id = 3, Name = "Creative Designs", Email = "hello@creativedesigns.io" },
			new() { Id = 4, Name = "HealthFirst Group", Email = "support@healthfirst.org" },
			new() { Id = 5, Name = "Modern Retailers", Email = "sales@modernretail.com" }
			};

			modelBuilder.Entity<Customer>().HasData(customers);

			// 2. Seed 20 Orders
			var orders = new List<Order>();
			var random = new Random();

			for (int i = 1; i <= 20; i++)
			{
				orders.Add(new Order
				{
					Id = i,
					// Distribute orders across the 5 customers
					CustomerId = (i % 5) + 1,
					TotalAmount = (decimal)(random.NextDouble() * 500 + 10), // Random amount between 10 and 510
					OrderDate = DateTime.UtcNow.AddDays(-random.Next(1, 30)) // Random date in the last 30 days
				});
			}

			modelBuilder.Entity<Order>().HasData(orders);
		}
	}
}
