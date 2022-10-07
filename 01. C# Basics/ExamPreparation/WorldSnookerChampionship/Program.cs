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
            string stage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int sumTicket = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());
            double priceForOneTicket = 0.0;
            switch (stage)
            {
                case "Quarter final":
                    if (typeTicket == "Standard")
                    {
                        priceForOneTicket = 55.50;
                    }
                    else if (typeTicket == "Premium")
                    {
                        priceForOneTicket = 105.20;
                    }
                    else if (typeTicket == "VIP")
                    {
                        priceForOneTicket = 118.90;
                    }
                    break;
                case "Semi final":
                    if (typeTicket == "Standard")
                    {
                        priceForOneTicket = 75.88;
                    }
                    else if (typeTicket == "Premium")
                    {
                        priceForOneTicket = 125.22;
                    }
                    else if (typeTicket == "VIP")
                    {
                        priceForOneTicket = 300.40;
                    }
                    break;
                case "Final":
                    if (typeTicket == "Standard")
                    {
                        priceForOneTicket = 110.10;
                    }
                    else if (typeTicket == "Premium")
                    {
                        priceForOneTicket = 160.66;
                    }
                    else if (typeTicket == "VIP")
                    {
                        priceForOneTicket = 400.0;
                    }
                    break;
            }
            double moneyForAllTickets = priceForOneTicket * sumTicket;
            if (moneyForAllTickets > 2500 && moneyForAllTickets <= 4000)
            {
                moneyForAllTickets *= 0.9;
                if (picture == 'Y')
                {
                    moneyForAllTickets += sumTicket * 40.0;
                }
            }
            else if (moneyForAllTickets > 4000)
            {
                moneyForAllTickets *= 0.75;
            }
            else
            {
                if (picture == 'Y')
                {
                    moneyForAllTickets += sumTicket * 40.0;
                }
            }
            Console.WriteLine($"{moneyForAllTickets:F2}");
        }
    }
}
