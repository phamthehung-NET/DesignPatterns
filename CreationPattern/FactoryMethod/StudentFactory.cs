using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    public class StudentFactory : PersonFactory
    {
        public override IPerson CreatePerson()
        {
            return new Student();
        }
    }
}
