using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //How to get a path of a directory
            var path = @"C:\Users\danie\source\repos\Documents\TownStateCountryList.txt";

            //Reading all the lines in a file from the path and storing it in a string array
            String[] lines = File.ReadAllLines(path);

            //Creating a list of our Place class
            //Values of the object will come from our text file
            var places = new List<Place>();

            Console.WriteLine("Enter: 1 to view all towns, 2 to view states and countries of a town");
            var option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                foreach (var line in lines)
                {
                    //Using the split method to split each line data into indexes
                    var split = line.Split(',');

                    //Assigning each splitted part to a variable
                    var town = split[0];
                    var state = split[1];
                    var country = split[2];

                    //Creating an object of the Contact class and using the values of the splited data
                    var place = new Place()
                    {
                        Town = town,
                        State = state,
                        Country = country
                    };

                    //Adding the created object to our list
                    places.Add(place);
                    Console.WriteLine($"Town: {place.Town}, State: {place.State}, Country: {place.Country}");
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter name of town");
                var input = Console.ReadLine();

                foreach (var line in lines)
                {
                    //Using the split method to split each line data into indexes
                    var split = line.Split(',');

                    //Assigning each splitted part to a variable
                    var town = split[0];
                    var state = split[1];
                    var country = split[2];

                    //Creating an object of the Contact class and using the values of the splited data
                    var place = new Place()
                    {
                        Town = town,
                        State = state,
                        Country = country
                    };

                    //Adding the created object to our list
                    places.Add(place);

                    var filter = places.Where(x => x.Town == input).ToList();

                    foreach (var item in filter)
                    {
                        Console.WriteLine($"Town: {item.Town}, State: {item.State}, Country: {item.Country}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}