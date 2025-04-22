using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.FactoryMethod
{
    public class TeacherFactory : PersonFactory
    {
        public override IPerson CreatePerson()
        {
            return new Teacher();
        }
    }
}
