namespace API_Fundamentals.Core.Entities
{
    public class Customer
    {
		public int Id { get; set; }
		public required string Name { get; set; }
		public string Email { get; set; } = string.Empty;
		// One-to-Many: One Customer has many Orders
		public List<Order> Orders { get; set; } = [];
	}
}
