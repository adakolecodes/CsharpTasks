using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationApp.Data.Scaffolded;

namespace UserRegistrationApp
{
    public class People
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public int CreateAccount(string name, string email)
        {
            var dbUser = new User();
            dbUser.Name = name;
            dbUser.Email = email;

            using (var dbContext = new UserRegistrationContext())
            {
                var result = dbContext.Users.SingleOrDefault(x => x.Email == email);
                if (result != null)
                {
                    return 0;
                }
                else
                {
                    dbContext.Users.Add(dbUser);
                    dbContext.SaveChanges();
                }
            }
            return dbUser.Id;
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var dbContext = new UserRegistrationContext())
            {
                return dbContext.Users.Select(x => x).ToList();
            }
        }

        public User GetUserByEmail(string email)
        {
            using (var dbContext = new UserRegistrationContext())
            {
                var result = dbContext.Users.SingleOrDefault(x => x.Email == email);

                var user = new User();
                user.Name = result.Name;
                user.Email = result.Email;

                return user;
            }
        }

        public
    }
}
