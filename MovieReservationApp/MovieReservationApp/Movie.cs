using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationApp
{
    internal class Movie
    {
        //public Movie()
        //{
        //    Viewers = new List<Viewer>();
        //}
        public string MovieTitle { get; set; }

        public string DateOfShow { get; set; }

        public List<Viewer> Viewers { get; set; }

        public Theatre Theatre { get; set; }
    }
}
