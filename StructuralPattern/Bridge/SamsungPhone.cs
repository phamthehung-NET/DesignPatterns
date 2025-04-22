using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Bridge
{
    internal class SamsungPhone : IDevice
    {
        public void Call(string phoneNumber, bool viaInternet)
        {
            Console.WriteLine("Samsung is calling to {0}", phoneNumber);
        }

        public void OpenApp(string appName)
        {
            Console.WriteLine("Samsung opened the {0}", appName);
        }

        public void TakeAPicture()
        {
            Console.WriteLine("Samsung took the picture");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine("Samsung send message \"{0}\" to {1}", message, phoneNumber);
        }
    }
}
