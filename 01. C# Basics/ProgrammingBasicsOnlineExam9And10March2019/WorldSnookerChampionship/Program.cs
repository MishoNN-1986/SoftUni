using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string round = Console.ReadLine();
            string ticket = Console.ReadLine();
            int sumTickets = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());
            double priceForOneTicket = 0;
            double allPrice = 0;

            switch (round)
            {
                case "Quarter final":
                    switch (ticket)
                    {
                        case "Standard":
                            priceForOneTicket = 55.5;
                            break;
                        case "Premium":
                            priceForOneTicket = 105.2;
                            break;
                        case "VIP":
                            priceForOneTicket = 118.9;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticket)
                    {
                        case "Standard":
                            priceForOneTicket = 75.88;
                            break;
                        case "Premium":
                            priceForOneTicket = 125.22;
                            break;
                        case "VIP":
                            priceForOneTicket = 300.4;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticket)
                    {
                        case "Standard":
                            priceForOneTicket = 110.1;
                            break;
                        case "Premium":
                            priceForOneTicket = 160.66;
                            break;
                        case "VIP":
                            priceForOneTicket = 400.0;
                            break;
                    }
                    break;
            }
            allPrice = sumTickets * priceForOneTicket;
            if (allPrice > 4000)
            {
                allPrice *= 0.75;
            }
            else if (allPrice > 2500)
            {
                allPrice *= 0.9;
                if (picture == 'Y')
                {
                    allPrice += sumTickets * 40;
                }
            }
            else
            {
                if (picture == 'Y')
                {
                    allPrice += sumTickets * 40;
                }
            }
            Console.WriteLine($"{allPrice:F2}");
        }
    }
}
