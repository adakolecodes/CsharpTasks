using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class AirlineService
    {
        static List<Plane> _planes;
        new Dictionary<string, Passenger> _passengers;
        List<Flight> _flights;

        public AirlineService()
        {
            _planes = new List<Plane>(){
                new Plane() { Name = "Nigerian Airways", AircraftNumber = 1320, NoOfSeats = 300 },
                new Plane() { Name = "Dana Airline", AircraftNumber = 2543, NoOfSeats = 250 },
                new Plane() { Name = "Overland Airways", AircraftNumber = 4321, NoOfSeats = 120 },
            };
            _passengers = new Dictionary<string, Passenger>();
            _flights = new List<Flight>();
        }

        public void AddPassengerMethod(string firstName, string surname, string passportNumber)
        {
            var passenger = new Passenger
            {
                FirstName = firstName,
                Surname = surname,
                PassportNumber = passportNumber
            };

            // Override if already in dictionary
            _passengers[passportNumber] = passenger;
        }

        public bool PlaneExistsMethod(int aircraftNumber)
        {
            return _planes.Any(x => x.AircraftNumber == aircraftNumber);

        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
        public bool PlaneExists2(int aircraftNumber, out int noOfSeats)
        {
            var found = _planes.FirstOrDefault(x => x.AircraftNumber == aircraftNumber);
            if(found == null)
            {
                noOfSeats = 0;
                return false;
            }
            else
            {
                noOfSeats = found.NoOfSeats;
                return true;
            }
        }

        public void AddFlightMethod(int flightNumber, int aircraftNumber, string takeoff, string destination,
            DateTime date)
        {
            var plane = _planes.First(x => x.AircraftNumber == aircraftNumber);
            _flights.Add(new Flight()
            {
                FlightNumber = flightNumber,
                Takeoff = takeoff,
                Destination = destination,
                Date = date,
                Plane = plane,
            });
        }

        // Why add Method to the method name. Pretty obvious it is a method no? :)
        public bool AddPassengerToFlightMethod(string passportNumber, int flightNumber)
        {
            if (!_passengers.ContainsKey(passportNumber))
                return false;

            var passenger = _passengers[passportNumber];
            var flight = _flights.Where(x => x.FlightNumber == flightNumber).FirstOrDefault();
            if (flight == null)
                return false;
            
            flight.Passengers.Add(passenger);
            return true;
        }

        // Why are you returning object?
        // Inconsitent access modifiers error. Check out these answers:
        // https://stackoverflow.com/questions/25260280/inconsistent-accessibility-error-parameter-is-less-accessible-than-method
        // Last answer: hhttps://stackoverflow.com/questions/13660355/inconsistent-accessibility-property-type-is-less-accessible?rq=1
        public IEnumerable<Flight> ViewFlightManifestMethod(int flightNumber)
        {
            // If doing FirstOrDefault you don't need ToList()
            // I would do .First() instead as you want it to throw an exception if it can't find it. And catch the exception in Program.ViewFlightManifest
            yield return _flights.Where(x => x.FlightNumber == flightNumber).First();
        }
    }
}


