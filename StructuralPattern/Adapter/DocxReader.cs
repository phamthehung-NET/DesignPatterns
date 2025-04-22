using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class DocxReader
    {
        public DocxReader(SampleFile file)
        {
            if (Path.GetExtension(file.FileName).Equals(".docx"))
            {
                Console.WriteLine("This is docx File, accepted");
                return;
            }
            Console.WriteLine("This file is not docx file, rejected");
        }
    }
}
