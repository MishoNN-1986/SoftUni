using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFoodForOneDay = double.Parse(Console.ReadLine());
            double moneyForSouvenirForOneDay = double.Parse(Console.ReadLine());
            double moneyForHotelForOneDay = double.Parse(Console.ReadLine());
            double moneyForFuel = 2.1 * 7 * 1.85 * 2;
            double allMoneyForHotel = moneyForHotelForOneDay * 0.9 + moneyForHotelForOneDay * 0.85 + moneyForHotelForOneDay * 0.8;
            double allMoney = moneyForSouvenirForOneDay * 3 + moneyForFoodForOneDay * 3 + moneyForFuel + allMoneyForHotel;
            Console.WriteLine($"Money needed: {allMoney:F2}");
        }
    }
}
