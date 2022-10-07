using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            double priceForOneCocktail = 0;
            double allPrice = 0;
            double priceForOneOrder = 0;
            while (allPrice < desiredProfit)
            {
                string command = Console.ReadLine();
                if (command == "Party!")
                {
                    Console.WriteLine($"We need {desiredProfit - allPrice:F2} leva more.");
                    break;
                }
                string nameOfCocktail = command;
                int quantityOfCocktail = int.Parse(Console.ReadLine());
                priceForOneCocktail = nameOfCocktail.Length;
                priceForOneOrder = priceForOneCocktail * quantityOfCocktail * 1.0;
                if (priceForOneOrder % 2 == 1)
                {
                    priceForOneOrder *= 0.75;
                }
                allPrice += priceForOneOrder;
            }
            if (allPrice >= desiredProfit)
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {allPrice:F2} leva.");
        }
    }
}
