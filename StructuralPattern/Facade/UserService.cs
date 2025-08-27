using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal class UserService : IUserService
    {
        public void CheckUser(Order order)
        {
            Console.WriteLine("Checking customer for order...");
            if (string.IsNullOrEmpty(order.CustomerName))
            {
                Console.WriteLine("Customer is not registered");
            }
            else
            {
                Console.WriteLine("Order created by: {0}", order.CustomerName);
            }
        }
    }
}
