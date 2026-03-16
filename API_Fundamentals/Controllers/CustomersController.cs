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
		[HttpGet("{id:int}")] // Constraint ensures 'id' must be an integer
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CustomerDto>> Get(int id)
		{
			var result = await customerService.GetCustomerByIdAsync(id);

			if (result == null)
			{
				return NotFound(new { message = $"Customer with ID {id} not found." });
			}

			return Ok(result);
		}

		[Route("Get_all")]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
		{
			var result = await customerService.GetAllCustomersAsync();
			return Ok(result);
		}

		[HttpGet("with-orders")]
		public async Task<ActionResult<IEnumerable<CustomerWithOrdersDto>>> GetCustomersWithOrders()
		{
			var result = await customerService.GetAllCustomersWithOrdersAsync();
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
