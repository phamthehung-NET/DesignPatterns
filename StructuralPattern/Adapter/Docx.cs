using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class Docx
    {
        public SampleFile GetFile(string fileName)
        {
            return new()
            {
                FileName = fileName + ".docx",
                CreatedDate = DateTime.Now,
                Size = 32000,
            }; ;
        }
    }
}
