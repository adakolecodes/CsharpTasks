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
            var placeService = new PlaceService();

            while (true)
            {
                Console.WriteLine(@"
1 to display all places,
2 to search by town,
3 to search by state,
4 to see duplicate towns
");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    IEnumerable<Place> it = placeService.DisplayAllPlaces();
                    foreach (var item in it)
                    {
                        Console.WriteLine($"Town: {item.Town}, State: {item.State}, Country {item.Country}");
                    }
                    Console.WriteLine($"Total count is: {it.Count()}");
                }
                else if (option == "2")
                {
                    //Given a town name display a list of States and Countries it belongs to
                    Console.WriteLine("Enter Name of Town");
                    var townName = Console.ReadLine();

                    var result = placeService.SearchByTown(townName);

                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Total count is: {result.Count()}");
                }
                else if (option == "3")
                {
                    //Given a state name display a list of Towns and Countries it belongs to
                    Console.WriteLine("Enter Name of State");
                    var stateName = Console.ReadLine();

                    var result = placeService.SearchByState(stateName);

                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Total count is: {result.Count()}");
                }
                else if (option == "4")
                {
                    IEnumerable<IGrouping<string, Place>> unique = placeService.SeeDuplicateTowns();

                    foreach (var item in unique)
                    {
                        Console.WriteLine($"TOWN NAME: {item.Key}, DUPLICATE: {item.Count()}");
                    }
                    Console.WriteLine($"Total count is: {unique.Count()}");
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