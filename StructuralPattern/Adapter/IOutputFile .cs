using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Adapter
{
    internal interface IOutputFile
    {
        SampleFile ReturnFile(string fileName);
    }
}
