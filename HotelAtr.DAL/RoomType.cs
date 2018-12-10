using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelAtr.DAL
{
    [RoomTypeValidation]
    [Table("RoomType", Schema = "Table")]
    public class RoomType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }

        [Required(ErrorMessage = "Поле \"Описание\" обязательно для заполнения")]
        //[EmailAddress]
        //[StringLength(2000, 
        //    MinimumLength = 20, 
        //    ErrorMessage = "Недопустимая длина описания")]
        public string Description { get; set; }

        //[Range(1, 100, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }


        //[Required]
        public string Password { get; set; }

        //[Required]
        //[Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }


        //[Range(0, 500)]
        public int Price { get; set; }

        //[DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public List<Room> Room { get; set; }
    }
}
