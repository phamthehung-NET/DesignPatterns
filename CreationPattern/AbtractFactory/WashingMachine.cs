using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class WashingMachine : Machine
    {
        public override string Action()
        {
            return "Washing machine: Wash the clothes";
        }
    }
}
