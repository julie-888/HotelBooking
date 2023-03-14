using HotelBooking.Models;
using HotelBooking.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public readonly IBookingStorage _bookingStorage;

        public BookingController(IBookingStorage bookingStorage)

        {
            _bookingStorage = bookingStorage;
        }
        [HttpGet("hotels")]
        public Task<List<Hotel>> GetAllHotels()
        {
            var hotels = _bookingStorage.GetAllHotels();
            return Task.FromResult(hotels);
        }
        [HttpGet("rooms")]
        public Task<List<Room>> GetAllRooms()
        {
            var rooms = _bookingStorage.GetAllRooms();
            return Task.FromResult(rooms);

        }
    }
}
