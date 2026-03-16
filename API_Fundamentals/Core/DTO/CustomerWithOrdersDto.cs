namespace API_Fundamentals.Core.DTO
{
	public class CustomerWithOrdersDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		// This includes the list of orders
		public List<OrderDto> Orders { get; set; } = [];
	}
}
