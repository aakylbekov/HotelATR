using System;
using System.ComponentModel.DataAnnotations;

namespace HotelAtr.DAL
{
    public class RoomTypeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            RoomType roomType = value as RoomType;
            if (roomType.Age == 16 && roomType.Price > 100)
            {
                this.ErrorMessage = "Слишком мал для заказов";
                return false;
            }
            return true;
        }
    }
}