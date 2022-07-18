using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our dataSource
            List<int> dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };
            
            List<string> dataSourceString = new List<string>() { 
                "Zecharias",
                "Mathias",
                "Amos",
                "Jeremiah",
                "Benjamin",
                "Gideon",
                "David"
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(3, "Fred", "Smith", "fredsmith@gmail.com"),
                new Employee(2, "Mark", "Tim", "marktim@gmail.com"),
                new Employee(4, "Mark", "Allen", "markallen@gmail.com"),
                new Employee(1, "Fred", "Anderson", "fredanderson@gmail.com")
            };

            int[] rollNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //SORTING OPERATORS

            //OrderBy OPERATOR (Used to sort data in ascending order and can be applied on any data type
            //Method syntax
            var methodSyntax = dataSourceInt.OrderBy(x => x).ToList();
            var methodSyntax2 = dataSourceString.OrderBy(x => x).ToList();


            //Using Where and OrderBy operator
            //Method syntax (Order our dataSource numbers where the numbers are greater than 7)
            var whereAndOrderBymethodSyntax = dataSourceInt.Where(x => x > 7).OrderBy(x => x).ToList();


            //OrderByDescending OPERATOR (Used to sort data in descending data and can be applied on any data type)
            //Method syntax (Order our employees by id in descending order)
            var methodSyntax3 = employees.OrderByDescending(emp => emp.Id).ToList();


            //OrderBy and ThenBy OPERATOR
            var methodSyntax4 = employees.OrderBy(emp => emp.FirstName).ThenBy(emp => emp.LastName).ToList();

            foreach(var item in methodSyntax4)
            {
                Console.WriteLine($"Id: {item.Id}, First Name: {item.FirstName}, Last Name: {item.LastName}, Email: {item.Email}");
            }


            //Reverse OPERATOR (Used to reverse the order of a data set)
            var methodSyntax5 = rollNumbers.Reverse().ToList();



            Console.ReadLine();
        }
    }
}
