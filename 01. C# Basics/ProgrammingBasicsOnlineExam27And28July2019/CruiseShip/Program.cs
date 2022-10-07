using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string typeRoom = Console.ReadLine();
            int quantityNights = int.Parse(Console.ReadLine());
            double priceForOneNight = 0;
            switch (cruiseType)
            {
                case "Mediterranean":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForOneNight = 27.5;
                            break;
                        case "cabin with balcony":
                            priceForOneNight = 30.2;
                            break;
                        case "apartment":
                            priceForOneNight = 40.5;
                            break;
                    }
                    break;
                case "Adriatic":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForOneNight = 22.99;
                            break;
                        case "cabin with balcony":
                            priceForOneNight = 25.00;
                            break;
                        case "apartment":
                            priceForOneNight = 34.99;
                            break;
                    }
                    break;
                case "Aegean":
                    switch (typeRoom)
                    {
                        case "standard cabin":
                            priceForOneNight = 23.00;
                            break;
                        case "cabin with balcony":
                            priceForOneNight = 26.60;
                            break;
                        case "apartment":
                            priceForOneNight = 39.80;
                            break;
                    }
                    break;
            }
            if (quantityNights > 7)
            {
                priceForOneNight *= 0.75;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {priceForOneNight * quantityNights * 4.0:F2} lv.");
        }
    }
}
