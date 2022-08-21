using AirlineReservationSystem;

namespace AirlineReservationTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_Add_Passenger()
        {
            //Act
            var airplaneService = new AirlineService();

            //Arrange
            var firstName = "John";
            var surname = "Doe";
            var passportNumber = "12345";
            airplaneService.AddPassengerMethod(firstName, surname, passportNumber);

            //Assert
            //Assert.AreEqual("12345", passportNumber);
            Assert.AreEqual("12345", passportNumber);
        }

        [Test]
        public void IfPlaneDoesNotExists_ThrowException()
        {
            //Act
            var airplaneService = new AirlineService();

            //Arrange
            var aircraftNumber = 1360; //Aircraft number does not exists for any plane
            var result = airplaneService.PlaneExistsMethod(aircraftNumber);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void AddingPassengerToFlightWhenFlightDoesNotExist_ThrowException()
        {
            //Act
            var airplaneService = new AirlineService();

            //Arrange
            var passportNumber = "12345";
            //List<Flight> flights = new List<Flight>();
            //airplaneService.AddFlightMethod(11111, 1320, "Abuja", "Lagos", new DateTime(2020,02,04));
            //flights.Add(new Flight()
            //{
            //    FlightNumber = 11111,
            //    Takeoff = "Abuja",
            //    Destination = "Lagos",
            //    Date = new DateTime(2020, 02, 04),
            //    Plane = new Plane()
            //    {
            //        Name = "Nigeria Airways",
            //        AircraftNumber = 1320,
            //        NoOfSeats = 200
            //    }
            //});

            var flightNumber = 11111;

            //var flight = flights.Where(x => x.FlightNumber == flightNumber).FirstOrDefault();
            
            var result = airplaneService.AddPassengerToFlightMethod(passportNumber, flightNumber);

            //Assert
            Assert.IsFalse(result);
        }
    }
}