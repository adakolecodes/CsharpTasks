using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(0, "Lord of the rings");
            books.Add(1, "Hobbit");
            books.Add(2, "Romeo and Juliet");
            books.Add(3, "The Gamer");
            books.Add(4, "Skyline");

            Console.WriteLine(books.Count());
            Console.WriteLine("AVAILABLE BOOKS - Enter number of book to borrow");
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            //RemoveBook();
            for (int i = 0; i <= books.Count(); i++)
            {
                foreach (var items in books)
                {
                    Console.WriteLine(items);
                }
                RemoveBook();
                Console.WriteLine(books.Count());
            }

            void RemoveBook()
            {
                Console.Write("Enter:");
                string selectedNumber = Console.ReadLine();
                books.Remove(int.Parse(selectedNumber));
            }

            Console.ReadLine();
        }
    }
}
