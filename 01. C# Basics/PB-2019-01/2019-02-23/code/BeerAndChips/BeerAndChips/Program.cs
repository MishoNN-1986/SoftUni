using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberOfBottles = int.Parse(Console.ReadLine());
            int numberOfChips = int.Parse(Console.ReadLine());
            double moneyForBeers = numberOfBottles * 1.20;
            double moneyForChips = Math.Ceiling(moneyForBeers * 0.45 * numberOfChips);
            double allMoney = moneyForBeers + moneyForChips;
            double diff = Math.Abs(budget - allMoney);
            if (budget >= allMoney)
            {
                double leftMoney = diff;
                Console.WriteLine($"{name} bought a snack and has {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = diff;
                Console.WriteLine($"{name} needs {needMoney:F2} more leva!");
            }
        }
    }
}
