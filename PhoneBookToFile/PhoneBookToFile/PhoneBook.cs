using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBookToFile
{
    internal class PhoneBook
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        public string filePath = @"C:\Users\danie\source\repos\Documents\ContactLists.txt";

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


            StreamWriter write = new StreamWriter(filePath);
            write.Write(name);
            
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
                    string[] lines = File.ReadAllLines(filePath);

                    List<Contact> contactList = new List<Contact>();
                    foreach (string line in lines)
                    {
                        var split = line.Split();

                        var splittedName = split[0];
                        var splittedNnumber = split[1];

                        Contact contact = new Contact()
                        {
                            Name = splittedName,
                            PhoneNumber = splittedNnumber
                        };

                        contactList.Add(contact);

                        if (splittedName == name)
                        {
                            Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                        }
                    }

                    //Console.WriteLine(contacts[name]);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
            }
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
