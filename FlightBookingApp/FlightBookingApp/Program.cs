using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planes = new List<Plane>()
            {
                new Plane(){ Name="Nigerian Airways", AircraftNumber = 1320, NoOfSeats = 300},
                new Plane(){ Name="Dana Airline", AircraftNumber = 2543, NoOfSeats = 250},
                new Plane(){ Name="Overland Airways", AircraftNumber = 4321, NoOfSeats = 120},
            };

            var flights = new List<Flight>();
            var passengers = new Dictionary<string, Passenger>();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("What do you want to do?\n Enter\n 1 to add passenger,\n 2 to add new flight,\n 3 to add passenger to flight,\n 4 to view flight manifest");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    // get passenger details
                    Console.WriteLine("Enter passenger first name, surname and passport no. in this order: John Doe 123456789");
                    var passengerDetails = Console.ReadLine();
                    var split = passengerDetails.Split();
                    var firstName = split[0];
                    var surname = split[1];
                    var passportNumber = split[2];

                    // Add it to dictionary of passengers
                    passengers.Add(passportNumber, new Passenger { FirstName = firstName, Surname = surname, PassportNumber = passportNumber });

                    Console.WriteLine("Passenger added successfully");
                    //Console.WriteLine($"First name: {passengers[passportNumber].FirstName}, Surname: {passengers[passportNumber].Surname}, Passport no: {passengers[passportNumber].PassportNumber}");
                }
                else if (input == "2")
                {
                    // get flight details: planeId, everything but passengers
                    // Add it to list of flight
                    Console.WriteLine("Which plane would you like to create a flight for? Enter Aircraft number");
                    var aircraftNumber = int.Parse(Console.ReadLine());
                    
                    try
                    {
                        var plane = planes.Where(x => x.AircraftNumber == aircraftNumber).First();

                        Console.Write("Flight Number: ");
                        var flightNumber = int.Parse(Console.ReadLine());
                        Console.Write("Takeoff point: ");
                        var takeoff = Console.ReadLine();
                        Console.Write("Destination: ");
                        var destination = Console.ReadLine();
                        Console.Write("Date of flight (eg 20130212): ");
                        var dateOfFlight = long.Parse(Console.ReadLine());

                        flights.Add(new Flight() { 
                            FlightNumber = flightNumber,
                            Takeoff = takeoff,
                            Destination = destination, 
                            Date = new DateTime(dateOfFlight), 
                            Plane = plane, 
                        });

                        Console.WriteLine("Flight created successfully");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if (input == "3")
                {
                    // Add a passenger to a flight
                    Console.Write("Enter passenger passport number: ");
                    var passportNumber = Console.ReadLine();
                    Console.Write("Enter flight number: ");
                    var flightNumber = int.Parse(Console.ReadLine());

                    try
                    {
                        var passenger = passengers[passportNumber];
                        var flight = flights.Where(x => x.FlightNumber == flightNumber).First();
                        flight.Passengers.Add(passenger);
                        Console.WriteLine("Passenger added successfully to flight");
                    }catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if (input == "4")
                {
                    // Display flight details and passenger list
                    Console.Write("Enter flight number: ");
                    var flightNumber = int.Parse(Console.ReadLine());
                    var flight = flights.Where(x => x.FlightNumber == flightNumber).First();
                    Console.WriteLine("FLIGHT DETAILS");
                    Console.WriteLine($"Flight number: {flight.FlightNumber}, Takeoff: {flight.Takeoff}, Destination: {flight.Destination}, Date: {flight.Date}, Plane: {flight.Plane.Name}");
                    Console.WriteLine("FLIGHT PASSENGERS");
                    foreach(var passenger in flight.Passengers)
                    {
                        Console.WriteLine($"First Name: {passenger.FirstName}, Surname: {passenger.Surname}, Passport number: {passenger.PassportNumber}");
                    }
                }
            }
        }
    }
}
