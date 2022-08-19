using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGroupWorkAirlineReservationSystem2
{
    internal class AirlineService
    {
        List<Plane> plane;
        List<Flight> flight;
        Dictionary<long, Passenger> passenger;


         public AirlineService()
        {
            plane = new List<Plane>()
            {
                new Plane(){Name = "Emirates Airline", AirCraft_Number = 100023, NumberOfSeat = 700},
                new Plane(){Name = "Nigeria Fly", AirCraft_Number = 100033, NumberOfSeat = 600},
                new Plane(){Name = "The Eagle", AirCraft_Number = 100043, NumberOfSeat = 400}
            };

             flight = new List<Flight>();
             passenger = new Dictionary<long, Passenger>();
        }

        public void RegisterAPassenger(long phonenumber, string firstName, string lastName)
        {
            var passengers = new Passenger() { First_Name=firstName, Last_Name=lastName, Passport_No=phonenumber};
            passenger.Add(phonenumber, passengers);
            
        }
        public void AddAFlight(long flightNumber,string takeOff,string destination,string dateOfFlight,long aircraftNumber)
        {
            var planes = plane.Where(x => x.AirCraft_Number == aircraftNumber).First();
            if (planes == null)
            {
                throw new Exception();
            }
            else
            {
                var flights = new Flight()
                {
                    Flight_Number = flightNumber,
                    TakeOff = takeOff,
                    Destination = destination,
                    Date_Of_Flight = dateOfFlight,
                    Planes = planes
                };

                flight.Add(flights);
            }
        }
        public void AddAPassengerToAFlight(long passportNumber, long flightNumber)
        {
            var flights = flight.Where(x => x.Flight_Number == flightNumber).FirstOrDefault();
            var passengers = passenger[passportNumber];
            if(flights==null)
            {
                throw new Exception();
            }
            else
            {
                flights.Passengers.Add(passengers);
            }
        }

    }
}
