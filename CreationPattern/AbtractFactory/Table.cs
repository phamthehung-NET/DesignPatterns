using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class Table : StaticItem
    {
        public override string Action()
        {
            return "Table: storage items";
        }
    }
}
