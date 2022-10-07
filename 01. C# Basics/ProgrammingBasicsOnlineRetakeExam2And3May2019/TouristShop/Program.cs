using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double priceForAllProducts = 0.0;
            int countProducts = 0;
            while (priceForAllProducts <= buget)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine($"You bought {countProducts} products for {priceForAllProducts:F2} leva.");
                    break;
                }
                string nameProduct = command;
                double priceProduct = double.Parse(Console.ReadLine());
                double diff = buget - priceForAllProducts * 1.0;
                countProducts++;
                if (countProducts % 3 == 0)
                {
                    priceProduct *= 0.5;
                }
                if (priceProduct > diff)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {priceProduct - diff:F2} leva!");
                    break;
                }
                priceForAllProducts += priceProduct;
            }
        }
    }
}
