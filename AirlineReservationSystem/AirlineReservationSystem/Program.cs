using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Program
    {
        // Access modifiers: Go for the most restrictive you can get away with
        private static AirlineService _airplaneService = new AirlineService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"
What do you want to do?
Enter:
1 to add passenger,
2 to add new flight,
3 to add passenger to flight,
4 to view flight manifest");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    AddPassenger();
                }
                else if (input == "2")
                {
                    AddFlight();
                }
                else if (input == "3")
                {
                    // Add a passenger to a flight
                    AddPassengerToFlight();
                }
                else if (input == "4")
                {
                    ViewFlightManifest();
                }
                else
                {
                    Console.WriteLine("Please select a valid option");
                }
            }
        }


        private static void AddPassenger()
        {
            Console.WriteLine("Enter passenger first name, surname and passport no. in this order: John Doe 123456789");
            var passengerDetails = Console.ReadLine();
            var split = passengerDetails.Split();
            var firstName = split[0];
            var surname = split[1];
            var passportNumber = split[2];

            _airplaneService.AddPassengerMethod(firstName, surname, passportNumber);
            Console.WriteLine($"Added passenger with passport number {passportNumber}");
        }

        // Access modifiers: Go for the most restrictive you can get away with
        private static void AddFlight()
        {
            Console.WriteLine("Which plane would you like to create a flight for? Enter Aircraft number");
            var aircraftNumber = int.Parse(Console.ReadLine());
            var exists = _airplaneService.PlaneExistsMethod(aircraftNumber);
            if (!exists)
            {
                Console.WriteLine("The plane has not been found.");
                return;
            }

            Console.Write("Flight Number: ");
            var flightNumber = int.Parse(Console.ReadLine());
            Console.Write("Takeoff point: ");
            var takeoff = Console.ReadLine();
            Console.Write("Destination: ");
            var destination = Console.ReadLine();
            Console.Write("Date of flight (eg 2013-02-12): ");
            var dateInput = Console.ReadLine();

            if (!DateTime.TryParse(dateInput, out var date))
            {
                Console.WriteLine("The Date is not readable");
                return;
            }
            _airplaneService.AddFlightMethod(flightNumber, aircraftNumber, takeoff, destination, date);

    
            Console.WriteLine("Flight created successfully");
        }

        private static void AddPassengerToFlight()
        {
            Console.Write("Enter passenger passport number: ");
            var passportNumber = Console.ReadLine();
            Console.Write("Enter flight number: ");
            var flightNumber = int.Parse(Console.ReadLine());

            var success = _airplaneService.AddPassengerToFlightMethod(passportNumber, flightNumber);

            if (success)
            {
                Console.WriteLine("Passenger added To flight");
            }
            else
            {
                Console.WriteLine("Passenger Unable to be added to flight");
            }
        }

        private static void ViewFlightManifest()
        {
            // Display flight details and passenger list
            Console.Write("Enter flight number: ");
            var flightNumber = int.Parse(Console.ReadLine());

            IEnumerable<Flight> flight = _airplaneService.ViewFlightManifestMethod(flightNumber);

            Console.WriteLine("FLIGHT DETAILS");
            foreach (var item in flight)
            {
                Console.WriteLine($"Flight number: {item.FlightNumber}, Takeoff: {item.Takeoff}, Destination: {item.Destination}, Date: {item.Date}, Plane: {item.Plane.Name}");
            }

            //Console.WriteLine("FLIGHT PASSENGERS");

            //foreach (var passenger in flight)
            //{
            //    Console.WriteLine($"First Name: {passenger}, Surname: {passenger.Surname}, Passport number: {passenger.PassportNumber}");
            //}
        }
    }

    
}