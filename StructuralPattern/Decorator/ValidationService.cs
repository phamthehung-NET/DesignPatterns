using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Decorator
{
    internal class ValidationService(IUserService service) : IUserService
    {
        public void CreateUser(User user)
        {
            if(string.IsNullOrEmpty(user.Name))
            {
                Console.WriteLine("User name cannot be empty");
                return;
            }
            
            if(string.IsNullOrEmpty(user.Email))
            {
                Console.WriteLine("User email cannot be empty");
                return;
            }
            
            if(!user.Email.Contains("@"))
            {
                Console.WriteLine("User email is not valid");
                return;
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                Console.WriteLine("User password cannot be empty");
                return;
            }

            service.CreateUser(user);
        }
    }
}
