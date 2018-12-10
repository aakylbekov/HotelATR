using System;
using System.Data.Entity;

namespace HotelAtr.DAL
{
    public class ModelEntity : DbContext
    {
        public ModelEntity() : base("name=DefaultConnection") {}
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<RoomOptions> RoomOptions { get; set; }
    }
}
