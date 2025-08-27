using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal class OrderService : IOrderService
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine("Order {0} {1} with price {2} is created by {3} at {4}", order.Quantity, order.ProductName, (order.Price * order.Quantity).ToString("n0"), order.CustomerName, order.OrderDate.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
