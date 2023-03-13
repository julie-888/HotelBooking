namespace HotelBooking.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string RoomName { get; set; } 
        public string RoomDescription { get; set; } 
        public int RoomSquare { get; set; } = 0;
        public virtual Hotel Hotel{ get; set; }
        public DateTime? ArrivalDate { get; set; } 
        public DateTime? DepartureDate { get; set; } 
        public virtual ICollection<Picture> PictureList { get;set; }
        public virtual ICollection<AdditionalParamsRoomsMap> AdditionalParamsRoomsMaps { get;set; }
        public virtual User User { get; set; }
        public int? BookedBy { get; set; }

    }
}
