using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationPattern.FactoryMethod;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    internal class PersonFactory
    {
        public static IPerson CreatePerson(PersonType personType)
        {
            return personType switch
            {
                PersonType.Teacher => new Teacher(),
                PersonType.Student => new Student(),
                PersonType.Engineer => new Engineer(),
                _ => null,
            };
        }
    }
}
