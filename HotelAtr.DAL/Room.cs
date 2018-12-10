using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelAtr.DAL
{
    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        public int RoomTypeId { get; set; }

        public int Floor { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string PathBasePicture { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual List<RoomOptions> RoomOptions { get; set; } 
    }
}
