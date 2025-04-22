using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationPattern.FactoryMethod;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    public abstract class PersonFactory
    {
        public abstract IPerson CreatePerson();
    }
}
