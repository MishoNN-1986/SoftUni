using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int quantityVideoCards = int.Parse(Console.ReadLine());
            int quantityProssesors = int.Parse(Console.ReadLine());
            int quantityRamMemory = int.Parse(Console.ReadLine());
            double allSum = (quantityVideoCards * 250.0) + (0.35 * 250.0 * quantityVideoCards * quantityProssesors) + (0.1 * 250.0 * quantityVideoCards * quantityRamMemory);
            if (quantityVideoCards > quantityProssesors)
            {
                allSum *= 0.85;
            }
            if (buget >= allSum)
            {
                Console.WriteLine($"You have {buget - allSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {allSum - buget:F2} leva more!");
            }
        }
    }
}
