using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double prizeForExcursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            double sum = puzzles * 2.6 + dolls * 3.0 + bears * 4.10 + minions * 8.20 + truck * 2.0;
            double finalSum = 0;
            int sumOfToy = puzzles + dolls + bears + minions + truck;
            if (sumOfToy >= 50)
            {
                finalSum = sum * 0.75 * 0.90;
            }
            else
            {
                finalSum = sum * 0.90;
            }
            if (finalSum >= prizeForExcursion)
            {
                double leftMoney = finalSum - prizeForExcursion;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double needMoney = prizeForExcursion - finalSum;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }
        }
    }
}
