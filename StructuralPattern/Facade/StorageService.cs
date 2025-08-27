
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    internal class StorageService : IStorageService
    {
        public bool IsInStock(int quantity)
        {
            return new Random().Next(2) == 0;
        }
    }
}
