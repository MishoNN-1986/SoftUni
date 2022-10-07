using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double charityAmount = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());
            double allMoney = fantasyBooks * 14.90 + horrorBooks * 9.80 + romanticBooks * 4.30;
            allMoney = allMoney * 0.8;
            if (allMoney >= charityAmount)
            {
                double remuneration = Math.Floor((allMoney - charityAmount) * 0.1);
                double diff = allMoney - remuneration;
                Console.WriteLine($"{diff:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {remuneration} leva.");
            }
            else
            {
                double needMoney = charityAmount - allMoney;
                Console.WriteLine($"{needMoney:F2} money needed.");
            }
        }
    }
}
