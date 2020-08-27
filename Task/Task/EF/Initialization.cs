using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Models;

namespace Task.EF
{
    public class Initialization
    {
        public static void Initialize(UsersContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Name = "Ivan",
                        Password = "12345",
                        Login = "Ivan01"
                    },
                     new User
                     {
                         Name = "Petr",
                         Password = "qwert",
                         Login = "Petr00"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
