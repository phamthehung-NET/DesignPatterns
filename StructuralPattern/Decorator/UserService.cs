using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Decorator
{
    internal class UserService : IUserService
    {
        public void CreateUser(User user)
        {
            Console.WriteLine($"User {user.Name} with email {user.Email} created.");
        }
    }
}
