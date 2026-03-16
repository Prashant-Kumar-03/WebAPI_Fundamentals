using API_Fundamentals.Core.DTO;
using API_Fundamentals.Core.Entities;
using API_Fundamentals.Core.Interafces;
using API_Fundamentals.Infrastructure.Data;
using API_Fundamentals.Infrastructure.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Fundamentals.Controllers
{
	[ApiController]
	[Route("api/Customers")]
	//[Authorize] // 🔒 Now, no one can access these endpoints without a valid token
	public class CustomersController(ICustomerService customerService) : ControllerBase
	{
		[Route("Get_all")]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
		{
			var result = await customerService.GetAllCustomersAsync();
			return Ok(result);
		}
		[Route("with orders")]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersWithOrders()
		{
			var result = await customerService.GetCustomersWithOrdersAsync();
			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)] // Documents the 201
		[ProducesResponseType(StatusCodes.Status400BadRequest)] // Documents the 400
		public async Task<ActionResult<CustomerDto>> CreateCustomer(CustomerCreateDto customerDto)
		{
			var result = await customerService.CreateCustomerAsync(customerDto);

			return CreatedAtAction(nameof(GetCustomers), new { id = result.Id }, result);
		}
	}
}
