namespace API_Fundamentals.Core.DTO
{
	public class CustomerCreateDto
	{
		public required string Name { get; set; }
		public string Email { get; set; } = string.Empty;
	}
}
