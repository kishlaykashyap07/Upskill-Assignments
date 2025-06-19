using OrderProcessingSystem.Models;
using OrderProcessingSystem.Processors;
using OrderProcessingSystem.Services;

namespace OrderProcessingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create order processors
            var processors = new List<IOrderProcessor>
            {
                new PhysicalProductProcessor(),
                new BookProcessor(),
                new MembershipProcessor(),
                new MembershipUpgradeProcessor(),
                new VideoProcessor()
            };

            // Create order processing service
            var orderProcessingService = new OrderProcessingService(processors);

            // Create example orders
            var orders = CreateExampleOrders();

            // Process each order
            foreach (var order in orders)
            {
                orderProcessingService.ProcessOrder(order);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static List<Order> CreateExampleOrders()
        {
            return new List<Order>
            {
                // Order with physical product
                new Order
                {
                    Id = 1,
                    CustomerId = "CUST001",
                    AgentId = "AGENT001",
                    Products = new List<Product>
                    {
                        new Product { Id = 1, Name = "Headphones", Type = ProductType.Physical, Price = 99.99m }
                    }
                },
                
                // Order with book
                new Order
                {
                    Id = 2,
                    CustomerId = "CUST002",
                    AgentId = "AGENT001",
                    Products = new List<Product>
                    {
                        new Product { Id = 2, Name = "Clean Code", Type = ProductType.Book, Price = 49.99m }
                    }
                },
                
                // Order with membership
                new Order
                {
                    Id = 3,
                    CustomerId = "CUST003",
                    Products = new List<Product>
                    {
                        new Product { Id = 3, Name = "Premium Membership", Type = ProductType.Membership, Price = 199.99m }
                    }
                },
                
                // Order with membership upgrade
                new Order
                {
                    Id = 4,
                    CustomerId = "CUST003",
                    Products = new List<Product>
                    {
                        new Product { Id = 4, Name = "Premium Plus Upgrade", Type = ProductType.MembershipUpgrade, Price = 99.99m }
                    }
                },
                
                // Order with Learning to Ski video
                new Order
                {
                    Id = 5,
                    CustomerId = "CUST004",
                    AgentId = "AGENT002",
                    Products = new List<Product>
                    {
                        new Product { Id = 5, Name = "Learning to Ski", Type = ProductType.Video, Price = 29.99m }
                    }
                },
                
                // Order with another video
                new Order
                {
                    Id = 6,
                    CustomerId = "CUST005",
                    AgentId = "AGENT002",
                    Products = new List<Product>
                    {
                        new Product { Id = 6, Name = "Cooking Basics", Type = ProductType.Video, Price = 19.99m }
                    }
                },
                
                // Mixed order with multiple products
                new Order
                {
                    Id = 7,
                    CustomerId = "CUST006",
                    AgentId = "AGENT003",
                    Products = new List<Product>
                    {
                        new Product { Id = 7, Name = "Mouse", Type = ProductType.Physical, Price = 29.99m },
                        new Product { Id = 8, Name = "Design Patterns", Type = ProductType.Book, Price = 54.99m },
                        new Product { Id = 9, Name = "Learning to Ski", Type = ProductType.Video, Price = 29.99m }
                    }
                }
            };
        }
    }
}