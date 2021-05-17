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
            int numberOfNights = int.Parse(Console.ReadLine());
            double Apartment = 0.0;
            double Studio = 0.0;
            double priceForAllNightsInApartment = 0.0;
            double priceForAllNightsInStudio = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    Studio = 50;
                    Apartment = 65;
                    break;
                case "June":
                case "September":
                    Studio = 75.20;
                    Apartment = 68.70;
                    break;
                case "July":
                case "August":
                    Studio = 76;
                    Apartment = 77;
                    break;
            }

            if (numberOfNights > 7 && numberOfNights <= 14 &&
                (month == "May" || month == "October"))
            {
                Studio *= 0.95;
            }
            else if (numberOfNights > 14 &&
                (month == "May" || month == "October"))
            {
                Studio *= 0.7;
            }
            else if (numberOfNights > 14 && 
                (month == "June" || month == "September"))
            {
                Studio *= 0.8;
            }

            if (numberOfNights > 14)
            {
                Apartment *= 0.9;
            }

            priceForAllNightsInApartment = numberOfNights * Apartment;
            priceForAllNightsInStudio = numberOfNights * Studio;

            Console.WriteLine($"Apartment: {priceForAllNightsInApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceForAllNightsInStudio:F2} lv.");


        }
    }
}
