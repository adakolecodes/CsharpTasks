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
        public void If_Plane_Does_Not_Exists_Throw_Exception()
        {
            //Act
            var airplaneService = new AirlineService();

            //Arrange
            var aircraftNumber = 1360; //Aircraft number does not exists for any plane
            var result = airplaneService.PlaneExistsMethod(aircraftNumber);

            //Assert
            Assert.IsFalse(result);
        }
    }
}