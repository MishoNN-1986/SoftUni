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
            double travelPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDollsTalking = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            int allToys = numberOfPuzzles + numberOfDollsTalking + numberOfTeddyBears + numberOfMinions + numberOfTrucks;
            double allMoney = numberOfPuzzles * 2.60 + numberOfDollsTalking * 3.00 + numberOfTeddyBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2.00;
            double allMoneyWin = allMoney;
            if (allToys >= 50)
            {
                allMoney = allMoney - allMoney * 0.25;
            }

            allMoneyWin = allMoney - allMoney * 0.10;
            if (allMoneyWin >= travelPrice)
            {
                Console.WriteLine($"Yes! {allMoneyWin - travelPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {travelPrice - allMoneyWin:F2} lv needed.");
            }
        }
    }
}
