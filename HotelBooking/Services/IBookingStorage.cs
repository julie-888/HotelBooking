using HotelBooking.EntityFramework;
using HotelBooking.Models;
using HotelBooking.Services;

namespace HotelBooking.Services
{
    public interface IBookingStorage
    {
        public List<Hotel> GetAllHotels();
        public List<Room> GetAllRooms();
    }
}
public class BookingStorage : IBookingStorage
{ 
    private readonly BookingDBContext _bookingDbContext;
    public List<Hotel> GetAllHotels()

    {
        return _bookingDbContext.Hotels.ToList();
    }

    public List<Room> GetAllRooms()

    {
        return _bookingDbContext.Rooms.ToList();
    }
}

