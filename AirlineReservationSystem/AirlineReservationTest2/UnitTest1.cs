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
        public void CanAddPassengerToFlight()
        {
            //Act
            var airplaneService = new AirlineService();

            //Arrange
            var flight = new Flight() { FlightNumber = 5421 };
            var passenger = new Passenger() { PassportNumber = "1360" };

            var passportNumber = passenger.PassportNumber;
            var flightNumber = flight.FlightNumber;
            var result = new Flight()
            {
                FlightNumber = flightNumber,
                Passengers = new Passenger() { PassportNumber = "1360" },
                Takeoff = "Abuja"
            };

            //Assert
            Assert.IsTrue(result);
        }
    }
}