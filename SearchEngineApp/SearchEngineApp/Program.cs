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
                var place = new Place(item.Name, item.County, item.Country);
                places.Add(place);
            }

            // Other way
            List<Place> placesWithLinq = allPlaces
                .Select(x => new Place(x.Name, x.County, x.Country))
                .ToList();



            Console.ReadLine();
        }
    }
}