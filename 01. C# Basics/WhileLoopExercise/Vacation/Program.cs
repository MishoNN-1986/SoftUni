using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoneyForVacation = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            double savedMoney = (double)moneyOnHand;
            double spendedMoney = 0;
            int countDaysWhitSpend = 0;
            int allDays = 0;
            while (savedMoney < needMoneyForVacation)
            {
                string action = Console.ReadLine();
                double moneyOfAction = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    spendedMoney = moneyOfAction;
                    savedMoney -= spendedMoney;
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                    countDaysWhitSpend++;
                    allDays++;
                    if (countDaysWhitSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{allDays}");
                        break;
                    }
                }
                else if (action == "save")
                {
                    savedMoney += moneyOfAction;
                    countDaysWhitSpend = 0;
                    allDays++;
                }
            }
            if (savedMoney >= needMoneyForVacation)
            {
                Console.WriteLine($"You saved the money for {allDays} days.");
            }
        }
    }
}
