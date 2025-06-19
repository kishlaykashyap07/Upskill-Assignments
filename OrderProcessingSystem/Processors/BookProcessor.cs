using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Processors
{
    public class BookProcessor : BaseOrderProcessor
    {
        public override void Process(Order order)
        {
            foreach (var product in order.Products)
            {
                if (IsApplicable(product, ProductType.Book))
                {
                    Console.WriteLine($"Generating packing slip for book: {product.Name}");

                    Console.WriteLine($"Generating duplicate packing slip for royalty department: {product.Name}");

                    Console.WriteLine($"Generating commission payment for book: {product.Name}");
                }
            }
        }
    }
}