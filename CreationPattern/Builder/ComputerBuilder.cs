using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.Builder
{
    public class ComputerBuilder
    {
        private Computer _computer = new();

        public ComputerBuilder AddCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder AddGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public ComputerBuilder AddRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public ComputerBuilder AddStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
