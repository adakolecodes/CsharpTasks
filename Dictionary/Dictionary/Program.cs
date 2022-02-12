using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary - One way of adding values to a dictionary
            var months = new Dictionary<int, string>
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
            };

            //Adding using the index notation
            months[5] = "May";
            months[6] = "June";
            months[7] = "July";
            //NB: Using same key in index notation method does not throw an error but only updates the value for that key


            //Adding value to the dictionary using the Add method
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");


            //NOTES: Dictionary keys are case sensitive, however we can ignor case sensitivity by parsing a parameter to it's constructor
            //Eg: <string, string>(StringComparer.OrdinalIgnoreCase);
            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            days["sun"] = "Sunday";
            days["mon"] = "Monday";
            days["tue"] = "Tuesday";

            //Retrieving value from a dictionary
            var sunday = days["sun"];
            Console.WriteLine(sunday);

            //When we try to fetch value from a dictionary and the key is not available it throws an excepton, however we can avoid this by using 'TryGetValue' method which returns false value if key is not available
            var wednesday = days.TryGetValue("wed", out string wed);
            Console.WriteLine(wednesday);


            Console.ReadKey();
        }
    }
}
