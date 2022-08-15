using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBookToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To store a contact: Eg STORE David 09012345678");
            Console.WriteLine("To view a contact: Eg VIEW David");
            Console.WriteLine("To update a contact: Eg UPDATE David");
            Console.WriteLine("To delete a contact: Eg DELETE David");

            //Create an object of the PhoneBook class
            var contact = new PhoneBook();



            while (true)
            {
                Console.Write("\nWhat do you want to do? ");
                var input = Console.ReadLine();
                var split = input.Split();
                var command = split[0];

                if (command == "STORE")
                {
                    var name = split[1];
                    var phoneNumber = split[2];

                    contact.AddContact(name, phoneNumber);
                }
                else if (command == "VIEW")
                {
                    var name = split[1];

                    contact.ViewContact(name);
                }
            }
        }
    }
}
