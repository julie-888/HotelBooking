namespace HotelBooking.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int IIN { get; set; }
        public virtual Room Room { get; set; }
        public int RoomID  { get; set; }

    }
}
