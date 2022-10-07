using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int sumNights = int.Parse(Console.ReadLine());
            int priceForOneNight = 0;
            switch (destination)
            {
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 30;
                            break;
                        case "24-27":
                            priceForOneNight = 35;
                            break;
                        case "28-31":
                            priceForOneNight = 40;
                            break;
                    }
                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 28;
                            break;
                        case "24-27":
                            priceForOneNight = 32;
                            break;
                        case "28-31":
                            priceForOneNight = 39;
                            break;
                    }
                    break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            priceForOneNight = 32;
                            break;
                        case "24-27":
                            priceForOneNight = 37;
                            break;
                        case "28-31":
                            priceForOneNight = 43;
                            break;
                    }
                    break;
            }
            int allSum = sumNights * priceForOneNight;
            Console.WriteLine($"Easter trip to {destination} : {allSum:F2} leva.");
        }
    }
}
