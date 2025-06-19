using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Processors
{
    public class MembershipUpgradeProcessor : BaseOrderProcessor
    {
        public override void Process(Order order)
        {
            foreach (var product in order.Products)
            {
                if (IsApplicable(product, ProductType.MembershipUpgrade))
                {
                    // Apply upgrade to membership
                    Console.WriteLine($"Applying membership upgrade: {product.Name} for customer: {order.CustomerId}");

                    // Send email notification
                    Console.WriteLine($"Sending membership upgrade email to customer: {order.CustomerId}");
                }
            }
        }
    }
}