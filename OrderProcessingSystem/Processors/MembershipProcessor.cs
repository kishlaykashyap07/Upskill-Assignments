using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Processors
{
    public class MembershipProcessor : BaseOrderProcessor
    {
        public override void Process(Order order)
        {
            foreach (var product in order.Products)
            {
                if (IsApplicable(product, ProductType.Membership))
                {
                    // Activate membership
                    Console.WriteLine($"Activating membership: {product.Name} for customer: {order.CustomerId}");

                    // Send email notification
                    Console.WriteLine($"Sending membership activation email to customer: {order.CustomerId}");
                }
            }
        }
    }
}