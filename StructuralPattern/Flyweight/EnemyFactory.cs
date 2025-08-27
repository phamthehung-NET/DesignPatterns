using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Flyweight
{
    internal class EnemyFactory
    {
        private static readonly Dictionary<string, IEnemy> _enemies = new();

        public static IEnemy GetEnemy(string type)
        {
            if (!_enemies.ContainsKey(type))
            {
                Console.WriteLine($"Creating new enemy of type: {type}");
                _enemies[type] = type switch
                {
                    "Normal" => new NormalEnemy(),
                    _ => throw new NotSupportedException()
                };
            }
            return _enemies[type];
        }
    }
}
