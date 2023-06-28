using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationPattern.AbtractFactory;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class HouseHoldFactory : ItemFactory
    {
        public override Machine CreateMachine()
        {
            return new WashingMachine();
        }

        public override StaticItem CreateStaticItem()
        {
            return new Chair();
        }
    }
}
