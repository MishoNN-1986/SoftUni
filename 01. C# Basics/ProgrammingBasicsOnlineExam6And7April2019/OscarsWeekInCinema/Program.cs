using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int sumTickets = int.Parse(Console.ReadLine());
            double priceForOneTicket = 0.0;
            switch (name)
            {
                case "A Star Is Born":
                    switch (typeHall)
                    {
                        case "normal":
                            priceForOneTicket = 7.5;
                            break;
                        case "luxury":
                            priceForOneTicket = 10.50;
                            break;
                        case "ultra luxury":
                            priceForOneTicket = 13.5;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (typeHall)
                    {
                        case "normal":
                            priceForOneTicket = 7.35;
                            break;
                        case "luxury":
                            priceForOneTicket = 9.45;
                            break;
                        case "ultra luxury":
                            priceForOneTicket = 12.75;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (typeHall)
                    {
                        case "normal":
                            priceForOneTicket = 8.15;
                            break;
                        case "luxury":
                            priceForOneTicket = 10.25;
                            break;
                        case "ultra luxury":
                            priceForOneTicket = 13.25;
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (typeHall)
                    {
                        case "normal":
                            priceForOneTicket = 8.75;
                            break;
                        case "luxury":
                            priceForOneTicket = 11.55;
                            break;
                        case "ultra luxury":
                            priceForOneTicket = 13.95;
                            break;
                    }
                    break;
            }
            double allSum = priceForOneTicket * sumTickets;
            Console.WriteLine($"{name} -> {allSum:F2} lv.");
        }
    }
}
