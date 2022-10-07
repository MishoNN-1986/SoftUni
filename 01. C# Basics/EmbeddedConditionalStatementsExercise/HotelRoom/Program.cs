using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double apartment = 0.0;
            double allPriceStudio = 0.0;
            double allPriceApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50.0;
                    apartment = 65.0;
                    if (nights > 7 && nights <= 14)
                    {
                        studio *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studio *= 0.7;
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    if (nights > 14)
                    {
                        studio *= 0.80;
                    }
                    break;
                case "July":
                case "August":
                    studio = 76.0;
                    apartment = 77.0;
                    break;
            }
            if (nights > 14)
            {
                apartment *= 0.9;
            }
            allPriceApartment = nights * apartment;
            allPriceStudio = nights * studio;
            Console.WriteLine($"Apartment: {allPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {allPriceStudio:F2} lv.");
        }
    }
}
