using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.Builder
{
    public class Computer
    {
        public string CPU { get; set; }

        public string GPU { get; set; }

        public string RAM { get; set; }

        public string Storage { get; set; }

        public override string ToString()
        {
            return "Computer => CPU: " + CPU + ", GPU: " + GPU + ", RAM: " + RAM + ", Storage: " + Storage;
        }
    }
}
