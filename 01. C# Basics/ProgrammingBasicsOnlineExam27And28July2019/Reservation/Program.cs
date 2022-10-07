using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfReservation = int.Parse(Console.ReadLine());
            int monthOfReservation = int.Parse(Console.ReadLine());
            int dayStartBreak = int.Parse(Console.ReadLine());
            int monthStartBreak = int.Parse(Console.ReadLine());
            int dayStopBreak = int.Parse(Console.ReadLine());
            int monthStopBreak = int.Parse(Console.ReadLine());
            double priceForOneNight = 30.0;
            if (dayStartBreak - dayOfReservation > 10)
            {
                priceForOneNight = 25;
            }
            if (monthOfReservation < monthStartBreak)
            {
                priceForOneNight = 25 * 0.8;
            }
            double allPrice = priceForOneNight * (dayStopBreak - dayStartBreak);
            Console.WriteLine($"Your stay from {dayStartBreak}/{monthStartBreak} to {dayStopBreak}/{monthStopBreak} will cost {allPrice:F2}");
        }
    }
}
