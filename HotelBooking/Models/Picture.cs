namespace HotelBooking.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string ImageUrl { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room{ get; set; }
    }
}
