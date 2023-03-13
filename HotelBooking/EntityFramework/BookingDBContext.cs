using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.EntityFramework
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext(DbContextOptions<BookingDBContext> options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<AdditionalParams> AdditionalParams { get; set; }
        public DbSet<AdditionalParamsRoomsMap> AdditionalParamsRoomsMaps { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hotel>().Property(x => x.HotelId).ValueGeneratedOnAdd();
            builder.Entity<Room>().Property(x => x.RoomId).ValueGeneratedOnAdd();
            builder.Entity<User>().Property(x => x.UserId).ValueGeneratedOnAdd();
            builder.Entity<Picture>().Property(x => x.PictureId).ValueGeneratedOnAdd();
            builder.Entity<AdditionalParams>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<AdditionalParamsRoomsMap>().Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Entity<Room>().HasOne(x => x.User).WithOne(i => i.Room).HasForeignKey<User>(x => x.RoomID);

        }
    }
}
