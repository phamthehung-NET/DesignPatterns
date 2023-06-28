using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.AbtractFactory
{
    internal class TV : Machine
    {
        public override string Action()
        {
            return "TV: show the movies";
        }
    }
}
