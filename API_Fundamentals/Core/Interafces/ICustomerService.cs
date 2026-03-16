using API_Fundamentals.Core.DTO;

namespace API_Fundamentals.Core.Interafces
{
	public interface ICustomerService
	{
		Task<IEnumerable<CustomerDto>> GetAllCustomersAsync();
		Task<CustomerDto?> GetCustomerByIdAsync(int id);
		Task<CustomerDto> CreateCustomerAsync(CustomerCreateDto customerDto);
		Task<CustomerDto> 
	}
}
