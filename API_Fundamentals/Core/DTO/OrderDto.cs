namespace API_Fundamentals.Core.DTO
{
	public class OrderDto
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal TotalAmount { get; set; }
	}
}
