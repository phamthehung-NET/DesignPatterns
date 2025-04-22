using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Bridge
{
    internal class IPhone : IDevice
    {
        public void Call(string phoneNumber, bool viaInternet)
        {
            Console.WriteLine("Iphone is calling to {0}", phoneNumber);
        }

        public void OpenApp(string appName)
        {
            Console.WriteLine("Iphone opened the {0}", appName);
        }

        public void TakeAPicture()
        {
            Console.WriteLine("Iphone took the picture");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine("Iphone send message \"{0}\" to {1}", message, phoneNumber);
        }
    }
}
