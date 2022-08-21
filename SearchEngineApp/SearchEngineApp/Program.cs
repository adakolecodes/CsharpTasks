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
            var path = @"C:\Users\danie\source\repos\Documents\TownStateCountryList.txt";

            var placeNamesService = new PlaceNamesService();

            IEnumerable<PlaceNames> allPlaces = placeNamesService.GetPlaceNames(path);            
            
            var places = new List<Place>();

            foreach (var item in allPlaces)
            {
                //Copied data from PlaceName class to Place class and storing it in the list of Place
                var place = new Place(item.Name, item.County, item.Country);
                places.Add(place);
            }

            while (true)
            {
                Console.WriteLine(@"
1 to display all places,
2 to enter a given town
");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    foreach (var place in places)
                    {
                        Console.WriteLine($"Town: {place.Town}, State: {place.State}, Country {place.Country}");
                    }
                }
                else if (option == "2")
                {
                    //Given a town name display a list of States and Countries it belongs to
                    Console.WriteLine("Enter Name of Town");
                    var townName = Console.ReadLine();

                    var result = places.Where(x => x.Town == townName);

                    foreach (var place in result)
                    {
                        Console.WriteLine(place);
                    }
                }
            }



            // Other way
            //List<Place> placesWithLinq = allPlaces
            //    .Select(x => new Place(x.Name, x.County, x.Country))
            //    .ToList();

            Console.ReadLine();
        }
    }
}