using NUnit.Framework;
using System.Runtime.InteropServices;
using TestNinja.Fundamentals;

namespace Ninja_Test
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        [Ignore("Just wanted to ignore!")]
        public void CanBeCancelledBy_UserAdmin_True()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_MadeByUser_True()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_NotAdminNotMadeByUser_False()
        {
            var reservation = new Reservation();
            var user = new User();

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.False);
        }
    }
}
