using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassGroupWorkAirlineReservationSystem
{
    internal class Program
    {
        static void Main()
        {
            var plane = new List<Plane>()
            {
                new Plane(){Name = "Emirates Airline", AirCraft_Number = 100023, NumberOfSeat = 700},
                new Plane(){Name = "Emirates Airline", AirCraft_Number = 100023, NumberOfSeat = 700},
                new Plane(){Name = "Emirates Airline", AirCraft_Number = 100023, NumberOfSeat = 700}
            };

            var flights = new List<Flight>();
            var passengers = new Dictionary<long, Passenger>();

            while (true)
            {
                Console.WriteLine("WELCOME TO OUR AIRLINE MANAGEMENT SYSTEM");
                Console.WriteLine("OPERATIONS: Register a passenger :    Add a flight :    Add a passenger to a flight :    View flight details ");
                var options = Console.ReadLine();

                if(options=="Register a passenger")
                {
                    Console.WriteLine("ENTER YOUR FIRST NAME");
                    var firstname = Console.ReadLine();
                    Console.WriteLine("ENTER YOUR LAST NAME");
                    var lastname = Console.ReadLine();
                    Console.WriteLine("ENTER THE NUMBER ON YOUR PASSPORT");
                    try
                    {
                        var passportnumber = long.Parse(Console.ReadLine());
                        passengers.Add(passportnumber, new Passenger { First_Name = firstname, Last_Name = lastname, Passport_No = passportnumber });
                        Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY REGISTERED");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if(options=="Add a flight")
                {
                    Console.WriteLine("ENTER THE FLIGHT NUMBER");
                    var flightnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("DATE OF THE FLIGHT");
                    var dateofflight = Console.ReadLine();
                    Console.WriteLine("TAKE OFF");
                    var takeoff = Console.ReadLine();
                    Console.WriteLine("DESTINATION");
                    var destination = Console.ReadLine();

                    try
                    {
                        flights.Add(new Flight { Flight_Number = flightnumber, Date_Of_Flight = dateofflight, TakeOff = takeoff, Destination = destination });
                        Console.WriteLine("THE FLIGHT HAS BEEN ADDED SUCCESSFULLY");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if (options == "Add a passenger to a flight")
                {
                    Console.WriteLine("ENTER THE PASSPORT NUMBER OF THE PASSENGER");
                    var passportnumber = long.Parse(Console.ReadLine());
                    
                    Console.WriteLine("ENTER THE FLIGHT NUMBER YOU BOOKED FOR");
                    var flightnumber = long.Parse(Console.ReadLine());
                    var passenger = passengers[passportnumber];
                    try
                    {
                        var flight = flights.Where(x => x.Flight_Number == flightnumber).First();
                        flight.Passengers.Add(passenger);
                        Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY ADDED TO THE FLIGHT");
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                else if (options == "View flight details")
                {
                    Console.WriteLine("ENTER THE FLIGHT NUMBER TO CHECK DETAILS");
                    var flightnumber = long.Parse(Console.ReadLine());
                    try
                    {
                        var flight = flights.Where(x => x.Flight_Number == flightnumber).First();
                        Console.WriteLine($"Flight Number: {flight.Flight_Number}, Date of the flight: {flight.Date_Of_Flight}, Take off: {flight.TakeOff}, Destination: {flight.Destination}, Plane boarding the flight: {flight.Planes}");

                        foreach (var pass in flight.Passengers)
                        {
                            Console.WriteLine($"First Name: {pass.First_Name}, Last Name: {pass.Last_Name}, Passport Number: {pass.Passport_No}");
                        }
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }
    }
}
