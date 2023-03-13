namespace HotelBooking.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Raiting { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }        
    }
}
