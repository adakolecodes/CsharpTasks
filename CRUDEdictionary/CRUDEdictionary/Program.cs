using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEdictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADD TO DICTIONARY
            Console.WriteLine("ENTER KEY:");

            string userinput;
            userinput = Console.ReadLine();

            var contact = new Dictionary<int, string> { };
            contact.Add(1, "09034227044");
            contact.Add(2, "08176696870");
            contact.Add(3, "08179320080");
            contact.Add(4, "08087162157");
            contact.Add(5, "08123456789");
            
            if(int.Parse(userinput) > 5)
            {
                Console.WriteLine("Maximum phone book list exceeded");
            }
            else
            {
                Console.WriteLine("Phone number associated with this key is: " + contact[int.Parse(userinput)]);
                Console.WriteLine(contact.Count);
            }

            //UPDATE DICTIONARY
            Console.WriteLine("UPDATE");
            contact[1] = "11113332435";
            Console.WriteLine("Phone number associated with this key has been updated. New phone number is " + contact[int.Parse(userinput)]);

            //REMOVE/DELETE
            Console.WriteLine("REMOVE");
            contact.Remove(int.Parse(userinput));
            Console.WriteLine("Phone number with key of " + contact[int.Parse(userinput)] + " has been removed successfully");

            Console.ReadKey();
        }
    }
}
