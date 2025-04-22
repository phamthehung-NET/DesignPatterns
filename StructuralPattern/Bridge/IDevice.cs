using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Bridge
{
    internal interface IDevice
    {
        void Call(string phoneNumber, bool viaInternet);

        void OpenApp(string appName);

        void TakeAPicture();

        void Text(string phoneNumber, string message);
    }
}
