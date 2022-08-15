using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp
{
    internal class Flight
    {
        public Flight()
        {
            Passengers = new List<Passenger>();
        }
        public int FlightNumber { get; set; }
        public string Takeoff { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public List<Passenger> Passengers { get; set; }
        public Plane Plane { get; set; }
    }
}
