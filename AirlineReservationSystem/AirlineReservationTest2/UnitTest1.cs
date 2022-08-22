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
            //Arrange
            var airplaneService = new AirlineService();

            //Act
            var firstName = "John";
            var surname = "Doe";
            var passportNumber = "12345";
            var result = airplaneService.AddPassengerMethod2(firstName, surname, passportNumber);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IfPlaneDoesNotExists_ThrowException()
        {
            //Arrange
            var airplaneService = new AirlineService();

            //Act
            var aircraftNumber = 1360; //Aircraft number does not exists for any plane
            var result = airplaneService.PlaneExistsMethod(aircraftNumber);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CanAddPassengerToFlight()
        {
            //Arrange
            var airplaneService = new AirlineService();

            //Act
            airplaneService.AddPassengerMethod("John", "Doe", "12345");
            airplaneService.AddFlightMethod(11111, 1320, "Abuja", "Lagos", new DateTime(2020, 02, 04));
            var result = airplaneService.AddPassengerToFlightMethod("12345", 11111);

            //Assert
            Assert.IsTrue(result);
        }
    }
}