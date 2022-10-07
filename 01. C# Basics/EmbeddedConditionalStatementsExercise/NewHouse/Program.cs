using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int quantityFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceForOneFlower = 0.0;
            double allPrice = 0.0;

            switch (typeFlowers)
            {
                case "Roses":
                    priceForOneFlower = 5.0;
                    if (quantityFlowers > 80)
                    {
                        priceForOneFlower *= 0.9;
                    }
                    break;
                case "Dahlias":
                    priceForOneFlower = 3.80;
                    if (quantityFlowers > 90)
                    {
                        priceForOneFlower *= 0.85;
                    }
                    break;
                case "Tulips":
                    priceForOneFlower = 2.80;
                    if (quantityFlowers > 80)
                    {
                        priceForOneFlower *= 0.85;
                    }
                    break;
                case "Narcissus":
                    priceForOneFlower = 3.0;
                    if (quantityFlowers < 120)
                    {
                        priceForOneFlower *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    priceForOneFlower = 2.50;
                    if (quantityFlowers < 80)
                    {
                        priceForOneFlower *= 1.20;
                    }
                    break;
            }
            allPrice = quantityFlowers * priceForOneFlower;
            if (budget >= allPrice)
            {
                double leftMoney = budget - allPrice;
                Console.WriteLine($"Hey, you have a great garden with {quantityFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = allPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }
        }
    }
}
