using Microsoft.AspNetCore.Identity;

namespace HotelBooking.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Room? Room { get; set; }
        public int? RoomID  { get; set; }
        public string? IIN  { get; set; }

    }
}
