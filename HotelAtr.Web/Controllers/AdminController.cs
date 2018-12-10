using HotelAtr.BAL;
using HotelAtr.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.Web.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Rooms()
        {
            RoomService service = new RoomService();
            return View(service.GetRooms());
        }

        public ActionResult AddRoom()
        {
            RoomService service = new RoomService();
            ViewBag.RoomsTypes = service.GetRoomsTypes();

            return View();
        }

        [HttpPost]
        public ActionResult AddRoom(Room room)
        {
            RoomService service = new RoomService();
            string message = "";
            if(service.CreateRoom(room, out message))
            {
                return RedirectToAction("Rooms");
            }
            else
            {

                return View(room);
            }
        }

        [HttpGet]
        public ActionResult EditRoom(int roomId)
        {
            RoomService service = new RoomService();

            ViewBag.RoomsTypes = service.GetRoomsTypes();

            if (roomId!=0)
            {
               
                Room room = service.GetRooms()
                    .FirstOrDefault(f => f.RoomId == roomId);

                if(room!= null)
                {
                    return View(room);
                }
            }

            return RedirectToAction("Rooms");
        }

        public ActionResult RoomTypeList()
        {
            RoomService RoomTypelist = new RoomService();
            return View(RoomTypelist.GetRoomsTypes());
        }
   
        public ActionResult EditRoomType(int id)
        {
            RoomService service = new RoomService();
            var roomtype = service.GetRoomsTypes().FirstOrDefault(p => p.RoomTypeId == id);
            return View(roomtype);
        }
        public ActionResult DetailsRoomType(int id)
        {
            RoomService service = new RoomService();
            var roomtype = service.GetRoomsTypes().FirstOrDefault(p => p.RoomTypeId == id);
            return View(roomtype);
        }

        public ActionResult CreateRoomType()
        {
            RoomType obj = new RoomType();
            return View(obj);
        }

        [HttpPost]
        public ActionResult CreateRoomType(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                //Add to DB
                return RedirectToAction("RoomTypeList");
            }
            else
            {
                return View(roomType);
            }
        }
    }
}