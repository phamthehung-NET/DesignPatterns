using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal class DocxAdapter : IOutputFile
    {
        private readonly Docx _docx;

        public DocxAdapter(Docx docx)
        {
            _docx = docx;
        }

        public SampleFile ReturnFile(string fileName)
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            return _docx.GetFile(fileNameWithoutExtension);
        }
    }
}
