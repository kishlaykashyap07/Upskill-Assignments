namespace OrderProcessingSystem.Processors
{
    public interface IOrderProcessor
    {
        void Process(Order order);
    }
}