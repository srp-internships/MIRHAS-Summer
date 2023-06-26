using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestNinja.Mocking;
using TestNinja.Mocking.ActionsOnBookingHelper;

namespace Ninja_Test.Mocking
{
    [TestFixture]
    class BookingHelperTests
    {
        [Test]
        private void OverlappingBookingsExistTest_BookingStatusCancelled_ReturnEmptyString()
        {
            var booking = new Booking() { Status = "Cancelled" };
            var result = BookingHelper.OverlappingBookingsExist(booking);

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void OverlappingBookingsExistTest_CheckIfGetMethodIsBeingCalledInARightWay()
        {
            var booking = new Booking();
            var getbookings = new Mock<IGetBookings>();
            BookingHelper.GetBookings = getbookings.Object;
            BookingHelper.OverlappingBookingsExist(booking);
            getbookings.Verify(a => a.Get());
        }

        [Test]
        public void OverlappingBookingsExistTest_Booking_ReturnOverlappingBooking()
        {
            var booking = new Booking()
            {
                Id = 1,
                Status = "InUse",
                ArrivalDate = DateTime.Today,
                DepartureDate = DateTime.Today.AddDays(1),
            };
            var bookings = new List<Booking>()
            {
                new Booking{Id=1,Status="Cancelled"},
                new Booking{Id=2,Status="InUse",ArrivalDate=DateTime.Today.AddDays(-1),DepartureDate=DateTime.Today.AddDays(1),Reference="reference"},
                new Booking{Id=3,Status="InUse"},
                new Booking{Id=4,Status="Cancelled"},
                new Booking{Id=5,Status="InUse"},

            };
            var getBooking = new Mock<IGetBookings>();
            getBooking.Setup(g => g.Get()).Returns(bookings);

            BookingHelper.GetBookings = getBooking.Object;
            var result = BookingHelper.OverlappingBookingsExist(booking);

            Assert.AreEqual("reference", result);
        }
    }
}
