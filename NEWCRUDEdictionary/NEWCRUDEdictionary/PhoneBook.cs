using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWCRUDEdictionary
{
    internal class PhoneBook
    {
        private Dictionary<string, long> book = new Dictionary<string, long>();
        //ADD METHOD
        public bool AddMethod(string name, long num)
        {
            //Check if key (contact name) already exists, if yes, then replace contact where key matches input, else add it
            if (book.ContainsKey(name))
            {
                return false;
            }
            else
            {
                book.Add(name, num);
                return true;
            }
        }

        public bool GetMethod(string name)
        {
            if (book.ContainsKey(name))
            {
                Console.WriteLine(book[name]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateMethod(string name, long num)
        {
            if (book.ContainsKey(name))
            {
                book[name] = num;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteMethod(string name)
        {
            if (book.ContainsKey(name))
            {
                book.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
