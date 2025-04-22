using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class XMLAdapter : IOutputFile
    {
        private readonly XML xml;

        public XMLAdapter(XML _xml)
        {
            xml = _xml;
        }

        public SampleFile ReturnFile(string fileName)
        {
            return xml.GetFile(fileName);
        }
    }
}
