namespace HotelBooking.Models
{
    public class AdditionalParamsRoomsMap
    {
        public int Id { get; set; }
        public virtual Room Room { get; set; }
        public int RoomId { get; set; }
        public virtual AdditionalParams AdditionalParams { get; set; }
        public int AParamId { get; set; }
    }
}
