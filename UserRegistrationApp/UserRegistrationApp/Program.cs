using System;
using System.Linq;
using UserRegistrationApp.Data.Scaffolded;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new UserRegistrationContext())
            {
                var user = new User(){ Name = "Daniel", Email = "daniel@gmail.com"};
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
