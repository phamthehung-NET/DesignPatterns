using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Composite
{
    internal class File : ISystemFile
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Info(string indent = "")
        {
            Console.WriteLine($"{indent} + File: " + _name);
        }
    }
}
