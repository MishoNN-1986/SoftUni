using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double price = 0.0;
            if (days < 10)
            {
                switch (typeRoom)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        price = 25.00 * 0.7;
                        break;
                    case "president apartment":
                        price = 35.00 * 0.90;
                        break;
                }
            }
            if (days >= 10 && days <= 15)
            {
                switch (typeRoom)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        price = 25.00 * 0.65;
                        break;
                    case "president apartment":
                        price = 35.00 * 0.85;
                        break;
                }
            }
            if (days > 15)
            {
                switch (typeRoom)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        price = 25.00 * 0.5;
                        break;
                    case "president apartment":
                        price = 35.00 * 0.80;
                        break;
                }
            }
            if (rating == "positive")
            {
                price = price * nights * 1.25;
            }
            else
            {
                price = price * nights * 0.90;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
