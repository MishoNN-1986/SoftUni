using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numExtras = double.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());

            double priceForDecor = budget * 0.10;
            double priceForAllClothing = 0.0;


            if (numExtras > 150)
            {
                priceForAllClothing = numExtras * priceForClothing * 0.9;
            }
            else
            {
                priceForAllClothing = numExtras * priceForClothing;
            }
            double allMoney = (double)priceForDecor + priceForAllClothing;

            if (allMoney > budget)
            {
                double needMoney = allMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
            else
            {
                double leftMoney = budget - allMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
        }
    }
}
