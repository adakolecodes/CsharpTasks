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

            var allPlaces = new FileReader();
            allPlaces.GetPlaceNames(path);

            var places = new List<Place>();

            places.Add();

            //Console.WriteLine($"Town: {allPlaces.Town}, State: {place.State}, Country: {place.Country}");

            Console.ReadLine();
        }
    }
}