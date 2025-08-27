using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Composite
{
    internal class Folder: ISystemFile
    {
        private string _name;

        private List<ISystemFile> _files = new();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(ISystemFile file)
        {
            _files.Add(file);
        }

        public void Info(string indent = "")
        {
            Console.WriteLine($"{indent} + Folder: " + _name);
            foreach (var file in _files)
            {
                file.Info(indent + "    ");
            }
        }
    }
}
