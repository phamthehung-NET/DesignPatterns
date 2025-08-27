using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Flyweight
{
    internal class NormalEnemy : IEnemy
    {
        public void Display(decimal powerValue)
        {
            Console.WriteLine($"Enemy with power value: {powerValue.ToString("n0")}");
        }
    }
}
