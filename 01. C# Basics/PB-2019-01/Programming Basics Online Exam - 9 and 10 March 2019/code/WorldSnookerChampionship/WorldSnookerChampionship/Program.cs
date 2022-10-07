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
            string stageOfChampionship = Console.ReadLine();  //etap na pyrvenstvoto
            string typeOfTicket = Console.ReadLine();   // vid na bileta
            int numberOfTickets = int.Parse(Console.ReadLine());  // broi bileti
            string photoWithTheTrophy = Console.ReadLine();  // snimka s trofeq
            double priceOfOneTicket = 0.0; // cena na 1 bilet
            double allPrice = 0.0;

            if (stageOfChampionship == "Quarter final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfOneTicket = 55.50;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfOneTicket = 105.20;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfOneTicket = 118.90;
                }
            }
            else if (stageOfChampionship == "Semi final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfOneTicket = 75.88;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfOneTicket = 125.22;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfOneTicket = 300.40;
                }
            }
            else if (stageOfChampionship == "Final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfOneTicket = 110.10;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfOneTicket = 160.66;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfOneTicket = 400.0;
                }
            }

            allPrice = priceOfOneTicket * numberOfTickets; // obshta cena na bileltite
            if (allPrice > 2500 && allPrice <= 4000)
            {
                allPrice *= 0.9;
                if (photoWithTheTrophy == "Y")
                {
                    allPrice += 40;
                }
            }
            else if (allPrice > 4000)
            {
                allPrice *= 0.75;
            }
            else
            {
                if(photoWithTheTrophy == "Y")
                {
                    allPrice += 40;
                }
            }
            Console.WriteLine($"{allPrice:F2}");

        }
    }
}
