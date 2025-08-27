using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal class OrderFacade(IStorageService storageService, IUserService userService, IOrderService orderService) : IOrderFacade
    {
        public void PlaceOrder(Order order)
        {
            if(!storageService.IsInStock(order.Quantity)) 
            {
                Console.WriteLine("Item is out of stock.");
                return;
            }

            Console.WriteLine("Item in stock");

            userService.CheckUser(order);

            orderService.CreateOrder(order);
        }
    }
}
