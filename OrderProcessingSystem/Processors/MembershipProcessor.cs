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
                    Console.WriteLine($"Activating membership: {product.Name} for customer: {order.CustomerId}");

                    Console.WriteLine($"Sending membership activation email to customer: {order.CustomerId}");
                }
            }
        }
    }
}