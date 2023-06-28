using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class Client
    {
        private readonly StaticItem staticItem;

        private readonly Machine machine;

        public Client(ItemFactory factory)
        {
            machine = factory.CreateMachine();
            staticItem = factory.CreateStaticItem();
        }

        public void GetAction()
        {
            Console.WriteLine("Static Action: " + staticItem.Action());
            Console.WriteLine("Machine Action: " + machine.Action());
        }
    }
}
