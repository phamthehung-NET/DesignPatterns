using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class XmlReader
    {
        public XmlReader(SampleFile file)
        {
            if (Path.GetExtension(file.FileName).Equals(".xml"))
            {
                Console.WriteLine("This is xml File, accepted");
                return;
            }
            Console.WriteLine("This file is not xml file, rejected");
        }
    }
}
