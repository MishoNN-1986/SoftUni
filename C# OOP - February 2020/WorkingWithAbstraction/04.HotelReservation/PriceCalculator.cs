using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HotelReservation
{
    public class PriceCalculator
    {
        public decimal Calculate(decimal pricePerDay,
            int numberOfDays,
            Season season,
            Discount discount = Discount.none) // по дефоулт няма отстъпка
                                               // може и със swich season и discount
        {
            var price = pricePerDay * numberOfDays * (int)season * ((100.0m - (int)discount) / 100.0m);
            return decimal.Parse($"{price:F2}");
        }
    }
}
