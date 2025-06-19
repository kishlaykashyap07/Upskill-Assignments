namespace OrderProcessingSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public string? CustomerId { get; set; }
        public string? AgentId { get; set; }
    }
}