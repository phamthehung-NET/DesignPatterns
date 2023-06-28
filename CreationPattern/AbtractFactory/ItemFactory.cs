using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal abstract class ItemFactory
    {
        public abstract StaticItem CreateStaticItem();

        public abstract Machine CreateMachine();
    }
}
