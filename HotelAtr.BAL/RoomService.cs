using HotelAtr.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.BAL
{
    public class RoomService
    {
        public bool CreateRoom(Room room, out string message)
        {
            using (ModelEntity db = new ModelEntity())
            {
                try
                {
                    db.Room.Add(room);
                    db.SaveChanges();

                    message = "Room Successful";
                    return true;
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    return false;
                }
            }
        }

        public bool CreateRoomType(RoomType roomType, out string message)
        {
            using (ModelEntity db = new ModelEntity())
            {
                try
                {
                    db.RoomType.Add(roomType);
                    db.SaveChanges();
                    message = "RoomType Successful";
                    return true;
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    return false;
                }
            }
        }

        public bool CreateRoomOptions(RoomOptions roomOptions, out string message)
        {
            using (ModelEntity db = new ModelEntity())
            {
                try
                {
                    db.RoomOptions.Add(roomOptions);
                    db.SaveChanges();
                    message = "RoomOptions Successful";
                    return true;
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    return false;
                }
            }
        }


        public List<Room> GetRooms()
        {
            using (ModelEntity db = new ModelEntity()) {
                return db.Room.ToList();
            }
        }

        public List<RoomType> GetRoomsTypes()
        {
            using (ModelEntity db = new ModelEntity())
            {
                return db.RoomType.ToList();
            }
        }

        public List<RoomOptions> GetRoomsOptions()
        {
            using (ModelEntity db = new ModelEntity())
            {
                return db.RoomOptions.ToList();
            }
        }
    }
}
