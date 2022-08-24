using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SearchEngineApp
{
    public class PlaceService
    {
        List<Place> _places;
        public PlaceService()
        {
            var path = @"C:\Users\danie\source\repos\Documents\TownStateCountryList.txt";

            var placeNamesService = new PlaceNamesService();

            IEnumerable<PlaceNames> allPlaces = placeNamesService.GetPlaceNames(path);
            _places = new List<Place>();

            foreach (var item in allPlaces)
            {
                //Copied data from PlaceNames class to Place class and storing it in the list of Place
                var getPlace = new Place(RemoveTextInBrackets(item.Name), item.County, item.Country);
                _places.Add(getPlace);
            }
        }


        public string RemoveBracketsFromText(string word)
        {
            return $"{word.Replace("(", string.Empty).Replace(")", string.Empty)}";
        }

        public string RemoveTextInBrackets(string word)
        {
            return $"{Regex.Replace(word, @" ?\(.*?\)", string.Empty)}";
        }

        public IEnumerable<Place> DisplayAllPlaces()
        {
            return _places.Select(x => x);
        }

        public IEnumerable<Place> SearchByTown(string townName)
        {
            return _places.Where(x => x.Town == townName);
        }

        public IEnumerable<Place> SearchByState(string stateName)
        {
            return _places.Where(x => x.State == stateName);
        }

        public IEnumerable<IGrouping<string, Place>> SeeDuplicateTowns()
        {
            var res = _places.GroupBy(x => x.Town).Where(x => x.Count() > 1).Select(x => x);
            return res;
        }
    }
}
