using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Bridge
{
    internal class IosDevice : AndroidDevice
    {
        private readonly IDevice device;

        public IosDevice(IDevice _device) : base(_device)
        {
            device = _device;
        }

        public void MakeAFaceTime(string phoneNumber)
        {
            Console.WriteLine("Calling to {0} via FaceTime...", phoneNumber);
            device.Call(phoneNumber, true);
        }
    }
}
