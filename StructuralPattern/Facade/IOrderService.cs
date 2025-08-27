using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal interface IOrderService
    {
        void CreateOrder(Order order);
    }
}
