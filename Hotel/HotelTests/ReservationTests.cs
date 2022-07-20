using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Tests
{
    [TestClass()]
    public class ReservationTests
    {
        [TestMethod()]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var user = new User { IsAdmin = true };
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanBeCancelledBy_UserIsUser_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsTrue(result);
        }
    }
}