using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBookApp
{
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

        public void ViewContact(string name)
        {
            if (!contacts.ContainsKey(name))
            {
                Console.WriteLine("This contact does not exist in the contact list");
            }
            else
            {
                try
                {
                    Console.WriteLine(contacts[name]);
                }
                catch(Exception err)
                {
                    Console.WriteLine(err);
                }
            }
        }
    }
}
