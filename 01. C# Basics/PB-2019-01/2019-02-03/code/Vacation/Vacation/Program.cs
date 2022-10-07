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
            double needMoney = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int countSpend = 0;
            int days = 0;
            while (countSpend < 5)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    countSpend++;
                    moneyOnHand -= sum;
                    days++;
                    if (moneyOnHand < 0)
                    {
                        moneyOnHand = 0;
                    }
                }
                else if (action == "save")
                {
                    countSpend = 0;
                    moneyOnHand += sum;
                    days++;
                    if (moneyOnHand >= needMoney)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
            }
            if (countSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
