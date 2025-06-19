namespace OrderProcessingSystem.Services
{
    public class OrderProcessingService
    {
        private readonly List<IOrderProcessor> _processors;

        public OrderProcessingService(List<IOrderProcessor> processors)
        {
            _processors = processors;
        }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing order ID: {order.Id}");

            foreach (var processor in _processors)
            {
                processor.Process(order);
            }

            Console.WriteLine($"Order ID: {order.Id} processed successfully");
        }
    }
}