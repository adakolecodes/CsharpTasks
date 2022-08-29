using System;
using System.Linq;
using UserRegistrationApp;
using UserRegistrationApp.Data.Scaffolded;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var dbContext = new UserRegistrationContext())
            //{
            //    var user = new User(){ Name = "Daniel", Email = "daniel@gmail.com"};
            //    dbContext.Users.Add(user);
            //    dbContext.SaveChanges();
            //}

            var pple = new People();

            while (true)
            {
                Console.WriteLine(@"
1 to add user,
2 to view users
3 to update user
4 to delete user");

                var option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("Enter Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    var email = Console.ReadLine();
                    var user = pple.CreateAccount(name, email);
                    if(user == 0)
                    {
                        Console.WriteLine("User already exists");
                    }
                    else
                    {
                        Console.WriteLine("User registered successfully");
                    }
                    
                }else if (option == "2")
                {
                    Console.WriteLine("1 to view all users, 2 to view specific user");
                    var option2 = Console.ReadLine();

                    if(option2 == "1")
                    {
                        var allUsers = pple.GetAllUsers();

                        foreach (var user in allUsers)
                        {
                            Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
                        }
                    }else if (option2 == "2")
                    {
                        Console.Write("Provide user email: ");
                        var email = Console.ReadLine();

                        var user = pple.GetUserByEmail(email);

                        Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
                    }
                }
            }
        }
    }
}
