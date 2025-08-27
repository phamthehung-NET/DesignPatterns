using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal class Order
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; } = 40000;

        public int Quantity { get; set; } = 1;

        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
