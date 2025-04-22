using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Bridge
{
    internal class AndroidDevice
    {
        private readonly IDevice device;

        public AndroidDevice(IDevice _device)
        {
            device = _device;
        }

        public void MakeACall(string phoneNumber)
        {
            Console.WriteLine("Calling to {0} ...", phoneNumber);
            device.Call(phoneNumber, false);
        }

        public void OpenApp(string appName)
        {
            Console.WriteLine("App {0} is opened", appName);
            device.OpenApp(appName);
        }

        public void TakeAPicture()
        {
            Console.WriteLine("Saved");
            device.TakeAPicture();
        }

        public void TextAMessage(string phoneNumber, string text)
        {
            Console.WriteLine("Message \"{0}\" is sent to {1}", text, phoneNumber);
            device.Text(phoneNumber, text);
        }
    }
}
