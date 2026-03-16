namespace API_Fundamentals.Core.Entities
{
    public class Order
    {
		public int Id { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.UtcNow;
		public decimal TotalAmount { get; set; }

		// Foreign Key
		public int CustomerId { get; set; }
	}
}
