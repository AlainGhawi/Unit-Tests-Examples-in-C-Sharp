using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange 
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_MadeByUser_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserNotAllowed_ReturnsFalse()
        {
            //Arrange
            var user = new User();
            var differentUser = new User();
            var reservation = new Reservation { MadeBy = user};
            //Act
            var result = reservation.CanBeCancelledBy(differentUser);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
