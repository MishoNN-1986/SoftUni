using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int quantityFisher = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (quantityFisher % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (quantityFisher % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    if (quantityFisher % 2 == 0)
                    {
                        price *= 0.95;
                    }
                    break;
            }
            if (quantityFisher <= 6)
            {
                price *= 0.9;
            }
            else if (quantityFisher > 7 && quantityFisher <= 11)
            {
                price *= 0.85;
            }
            else
            {
                price *= 0.75;
            }
            if (budget >= price)
            {
                double leftMoney = budget - price;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = price - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }
        }
    }
}
