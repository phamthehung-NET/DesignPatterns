using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    internal class Engineer : IPerson
    {
        public string GetPerson()
        {
            return "This is Engineer";
        }
    }
}
