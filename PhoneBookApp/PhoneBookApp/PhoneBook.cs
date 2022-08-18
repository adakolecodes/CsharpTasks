using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBookApp
{
    // Remove the console write lines: Seperation of concerns
    internal class PhoneBook
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void AddContact(string name, string phoneNumber)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine("Contact already exists");
            }
            else
            {
                // Not sure this try catch serves a purpose. What is point in catch
                try
                {
                    WriteContact(name, phoneNumber);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
        }

        public void WriteContact(string name, string phoneNumber)
        {
            contacts.Add(name, phoneNumber);
            Console.WriteLine("Contact saved successfully!");
        }

        public string ViewContact(string name)
        {
            if (!contacts.ContainsKey(name))
            {
                throw new Exception("Not Found");
            }

            return contacts[name];
        }
    }
}
