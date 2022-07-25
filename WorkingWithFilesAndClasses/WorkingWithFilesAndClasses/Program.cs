using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFilesAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //How to get a path of a directory
            var path = @"C:\Users\danie\source\repos\Documents\Contacts.txt";

            //Reading all the lines in a file from the path and storing it in a string array
            String[] lines = File.ReadAllLines(path);

            //Creating a list of our Contact class
            //Values of the object will come from our text file
            List<Contact> contacts = new List<Contact>();

            foreach (var line in lines)
            {
                //Using the split method to split each line data into indexes
                var split = line.Split(',');

                //Assigning each splitted part to a variable
                var name = split[0];
                var number = split[1];

                //Creating an object of the Contact class and using the values of the splited data
                Contact contact = new Contact()
                {
                    Name = name,
                    Number = long.Parse(number)
                };

                //Adding the created object to our list
                contacts.Add(contact);

                Console.WriteLine($"Name: {contact.Name}, Number: {contact.Number}");
            }

            Console.ReadLine();
        }
    }
}
