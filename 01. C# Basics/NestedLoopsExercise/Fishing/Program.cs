using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumFish = int.Parse(Console.ReadLine());
            int countFish = 0;
            double allMoney = 0;
            double allMoneyWin = 0;
            double allMoneyLost = 0;
            while (countFish < sumFish)
            {
                string fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    break;
                }
                double kilograms = double.Parse(Console.ReadLine());
                countFish++;
                for (int i = 0; i < fishName.Length; i++)
                {
                    int money = fishName[i];
                    allMoney += money;
                }
                if (countFish % 3 == 0)
                {
                    allMoneyWin += allMoney / kilograms;
                }
                else
                {
                    allMoneyLost += allMoney / kilograms;
                }
                allMoney = 0;
            }
            if (countFish == sumFish)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            double diff = Math.Abs(allMoneyWin - allMoneyLost);
            if (allMoneyWin > allMoneyLost)
            {
                Console.WriteLine($"Lyubo's profit from {countFish} fishes is {diff:F2} leva.");
            }
            else if (allMoneyLost > allMoneyWin)
            {
                Console.WriteLine($"Lyubo lost {diff:F2} leva today.");
            }
        }
    }
}
