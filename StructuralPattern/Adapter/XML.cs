using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class XML
    {
        public SampleFile GetFile(string fileName)
        {
            return new()
            {
                FileName = fileName + ".xml",
                CreatedDate = DateTime.Now,
                Size = 10000,
            }; ;
        }
    }
}
