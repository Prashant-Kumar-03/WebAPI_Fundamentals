using API_Fundamentals.Core.DTO;
using API_Fundamentals.Core.Entities;
using API_Fundamentals.Core.Interafces;
using API_Fundamentals.Infrastructure.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Fundamentals.Infrastructure.Services
{
	public class CustomerService(StoreContext context, IMapper mapper, ILogger<CustomerService> logger) : ICustomerService
	{
		public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync()
		{
			logger.LogInformation("Fetching all customers from database.");
			var customers = await context.Customers.ToListAsync();
			return mapper.Map<IEnumerable<CustomerDto>>(customers);
		}

		public async Task<CustomerDto?> GetCustomerByIdAsync(int id)
		{
			var customer = await context.Customers.FindAsync(id);
			return customer == null ? null : mapper.Map<CustomerDto>(customer);
		}
		public async Task<IEnumerable<CustomerWithOrdersDto>> GetAllCustomersWithOrdersAsync()
		{
			// Eager loading the Orders table
			var customers = await context.Customers
				.Include(c => c.Orders)
				.ToListAsync();

			return mapper.Map<IEnumerable<CustomerWithOrdersDto>>(customers);
		}

		public async Task<CustomerDto> CreateCustomerAsync(CustomerCreateDto customerDto)
		{
			var customer = mapper.Map<Customer>(customerDto);
			context.Customers.Add(customer);
			await context.SaveChangesAsync();

			return mapper.Map<CustomerDto>(customer);
		}
	}
}
