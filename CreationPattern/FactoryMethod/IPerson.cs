using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    internal interface IPerson
    {
        string GetPerson();
    }

    public enum PersonType
    {
        Teacher,
        Student,
        Engineer
    }
}
