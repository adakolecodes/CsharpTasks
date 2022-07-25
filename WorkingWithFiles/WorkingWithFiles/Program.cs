using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //How to get a path of a directory
            var path = @"C:\Users\danie\source\repos\Documents\Contacts.txt";

            //How to read all the lines in a file from a path
            var lines = File.ReadAllLines(path);

            //Looping through the lines to display contents in the file
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
