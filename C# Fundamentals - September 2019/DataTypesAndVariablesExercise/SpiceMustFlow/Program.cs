using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStartingYield = int.Parse(Console.ReadLine());
            int countDays = 0;
            int totalAmountOfSpice = 0;
            for (int i = numberStartingYield; i >= 100; i -= 10)
            {
                countDays++;
                totalAmountOfSpice += i - 26;
            }
            if (totalAmountOfSpice >= 26)
            {
                totalAmountOfSpice -= 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(totalAmountOfSpice);
        }
    }
}
