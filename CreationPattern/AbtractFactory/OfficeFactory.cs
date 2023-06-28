using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationPattern.AbtractFactory;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class OfficeFactory : ItemFactory
    {
        public override Machine CreateMachine()
        {
            return new TV();
        }

        public override StaticItem CreateStaticItem()
        {
            return new Table();
        }
    }
}
