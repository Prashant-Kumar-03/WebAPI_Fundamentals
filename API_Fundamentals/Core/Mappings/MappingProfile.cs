using API_Fundamentals.Core.DTO;
using API_Fundamentals.Core.Entities;
using AutoMapper;

namespace API_Fundamentals.Core.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Source -> Destination
			// This maps the Customer Entity to the CustomerDto
			// Entity -> DTO (for GET)
			CreateMap<Customer, CustomerDto>();
			CreateMap<Order, OrderDto>();
			CreateMap<Customer, CustomerWithOrdersDto>();

			// DTO -> Entity (for POST)
			CreateMap<CustomerCreateDto, Customer>();
			
		}
	}
}
