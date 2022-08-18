using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineApp
{
    internal class FileReader
    {

        public IEnumerable<Place> GetPlaceNames(string fileLoc)
        {
            var lines = File.ReadAllLines(fileLoc);

            foreach (var line in lines)
            {
                var split = line.Split(",");
                yield return new Place(split[0], split[1], split[2]);
            }
        }

        //public void ReadFileToClass()
        //{
        //    var path = @"C:\Users\danie\source\repos\Documents\TownStateCountryList.txt";

        //    String[] lines = File.ReadAllLines(path);

        //    foreach (var line in lines)
        //    {
        //        var split = line.Split(',');

        //        var town = split[0];
        //        var state = split[1];
        //        var country = split[2];

        //        var place = new Place()
        //        {
        //            Town = town,
        //            State = state,
        //            Country = country
        //        };
        //    }
        //}
    }
}
