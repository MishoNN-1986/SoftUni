using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCity = Console.ReadLine();
            string typePacket = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceForOneDay = 0;
            double allPrice = 0;
            switch (nameCity)
            {
                case "Bansko":
                case "Borovets":
                    switch (typePacket)
                    {
                        case "withEquipment":
                            priceForOneDay = 100.0;
                            switch (vip)
                            {
                                case "yes":
                                    priceForOneDay *= 0.9;
                                    break;
                            }
                            break;
                        case "noEquipment":
                            priceForOneDay = 80.0;
                            switch (vip)
                            {
                                case "yes":
                                    priceForOneDay *= 0.95;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (typePacket)
                    {
                        case "withBreakfast":
                            priceForOneDay = 130.0;
                            switch (vip)
                            {
                                case "yes":
                                    priceForOneDay *= 0.88;
                                    break;
                            }
                            break;
                        case "noBreakfast":
                            priceForOneDay = 100.0;
                            switch (vip)
                            {
                                case "yes":
                                    priceForOneDay *= 0.93;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            if (days > 7)
            {
                days--;
            }
            allPrice = priceForOneDay * days * 1.0;
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (priceForOneDay == 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {allPrice:F2}lv! Have a nice time!");
            }
        }
    }
}
