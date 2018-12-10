using HotelAtr.BAL;
using HotelAtr.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.Web.Models
{
    public static class Helpers
    {
        public static MvcHtmlString CreateRoomList(this HtmlHelper html, string[] items)
        {
            RoomService service = new RoomService();

            //<ul></ul>
            TagBuilder ul = new TagBuilder("ul");
            foreach (Room item in service.GetRooms())
            {
                //<li></li>
                TagBuilder li = new TagBuilder("li");

                //<li>Name</li>
                li.SetInnerText(item.Name);

                //<ul><li>Name</li></ul>
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }
    }
}