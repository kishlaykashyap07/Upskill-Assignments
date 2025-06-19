using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Processors
{
    public abstract class BaseOrderProcessor : IOrderProcessor
    {
        public abstract void Process(Order order);

        protected bool IsApplicable(Product product, ProductType type)
        {
            return product.Type == type;
        }
    }
}