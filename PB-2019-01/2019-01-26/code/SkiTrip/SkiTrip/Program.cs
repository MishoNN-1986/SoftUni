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
            string roomType = Console.ReadLine();
            string award = Console.ReadLine();
            int nights = days - 1;
            double price = 0.0;


            if (roomType == "room for one person")

            {
                price = nights * 18.00;

            }
            else if (roomType == "apartment")
            {
                if (days < 10)
                {
                    price = nights * 25.00 * 0.70;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = nights * 25.00 * 0.65;
                }
                else if (days > 15)
                {
                    price = nights * 25.00 * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    price = nights * 35.00 * 0.90;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = nights * 35.00 * 0.85;
                }
                else if (days > 15)
                {
                    price = nights * 35.00 * 0.80;
                }

            }
            if (award == "positive")

            {
                price = price * 1.25;

            }
            else if (award == "negative")
            {
                price = price * 0.9;

            }
            Console.WriteLine($"{price:F2}");

        }

    }
}
