namespace OrderProcessingSystem.Processors
{
    public class PhysicalProductProcessor : BaseOrderProcessor
    {
        public override void Process(Order order)
        {
            foreach (var product in order.Products)
            {
                if (IsApplicable(product, ProductType.Physical))
                {
                    Console.WriteLine($"Generating packing slip for physical product: {product.Name}");

                    Console.WriteLine($"Generating commission payment for physical product: {product.Name}");
                }
            }
        }
    }
}