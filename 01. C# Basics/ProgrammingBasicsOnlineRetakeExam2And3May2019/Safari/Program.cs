using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double neededLiters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double allSum = neededLiters * 2.1 + 100;
            if (day == "Saturday")
            {
                allSum *= 0.9;
            }
            else if (day == "Sunday")
            {
                allSum *= 0.8;
            }
            double diff = Math.Abs(buget - allSum);
            if (buget >= allSum)
            {
                Console.WriteLine($"Safari time! Money left: {diff:F2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {diff:F2} lv.");
            }
        }
    }
}
