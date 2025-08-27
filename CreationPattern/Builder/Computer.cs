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

        public string PSU { get; set; }

        public string Motherboard { get; set; }

        public string Cooler { get; set; }

        public string Case { get; set; }

        public override string ToString()
        {
            return "Computer => \nCPU: " + CPU + ", \nMainBoard: " + Motherboard + ", \nGPU: " + GPU + ", \nRAM: " + RAM + ", \nStorage: " + Storage + ", \nCooler: " + Cooler + ", \nPSU: " + PSU + ", \nCase: " + Case;
        }
    }
}
