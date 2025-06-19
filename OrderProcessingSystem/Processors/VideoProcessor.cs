using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Processors
{
    public class VideoProcessor : BaseOrderProcessor
    {
        public override void Process(Order order)
        {
            foreach (var product in order.Products)
            {
                if (IsApplicable(product, ProductType.Video))
                {
                    // Generate packing slip for shipping
                    Console.WriteLine($"Generating packing slip for video: {product.Name}");

                    // Check if it's "Learning to Ski" video
                    if (product.Name == "Learning to Ski")
                    {
                        // Add free "First Aid" video
                        Console.WriteLine("Adding free \"First Aid\" video to packing slip due to court decision in 1997");
                    }
                }
            }
        }
    }
}