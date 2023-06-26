using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Mocking.ActionsOnBookingHelper
{
    public interface IGetBookings
    {
        List<Booking> Get();
    }

    public class GetBookings : IGetBookings
    {
        public List<Booking> Get()
        {
            var unitOfWork = new UnitOfWork();
            var bookings = unitOfWork.Query<Booking>().ToList<Booking>();
            return bookings;
        }
    }
}
