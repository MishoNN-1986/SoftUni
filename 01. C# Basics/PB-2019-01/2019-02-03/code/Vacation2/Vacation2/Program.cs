using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation2
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int countSpendDays = 0;
            int countAllDays = 0;
            while (ownedMoney < needMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    ownedMoney -= sum;
                    countSpendDays++;
                    countAllDays++;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
                else if(action == "save")
                {
                    ownedMoney += sum;
                    countSpendDays = 0;
                    countAllDays++;
                }
                if (countSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{countAllDays}");
                    break;                       
                }             
            }
            if (ownedMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {countAllDays} days.");
            }
        }
        
    }
}
