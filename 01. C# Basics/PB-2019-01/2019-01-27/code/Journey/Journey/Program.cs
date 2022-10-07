using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double spentMoney = 0.0;
            string kindOfHoliday = "";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    spentMoney = budget * 0.3;
                    kindOfHoliday = "Camp";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{kindOfHoliday} - {spentMoney:F2}");
                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    spentMoney = budget * 0.7;
                    kindOfHoliday = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{kindOfHoliday} - {spentMoney:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    spentMoney = budget * 0.4;
                    kindOfHoliday = "Camp";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{kindOfHoliday} - {spentMoney:F2}");
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    spentMoney = budget * 0.8;
                    kindOfHoliday = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{kindOfHoliday} - {spentMoney:F2}");
                }
            }
            else
            {

                destination = "Europe";
                spentMoney = budget * 0.9;
                kindOfHoliday = "Hotel";
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{kindOfHoliday} - {spentMoney:F2}");


            }
        }
    }
}
