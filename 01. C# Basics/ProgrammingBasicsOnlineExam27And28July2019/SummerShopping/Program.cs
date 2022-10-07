using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            double priceBeachTowel = double.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());
            double allPrice = priceBeachTowel + (priceBeachTowel * 2.0 / 3.0) + (priceBeachTowel * 2.0 / 3.0 * 0.75) + ((priceBeachTowel + (priceBeachTowel * 2.0 / 3.0 * 0.75)) / 3.0);
            allPrice *= (100.0 - percentageDiscount) / 100.0;
            if (buget >= allPrice)
            {
                Console.WriteLine($"Annie's sum is {allPrice:F2} lv. She has {buget - allPrice:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {allPrice:F2} lv. She needs {allPrice - buget:F2} lv. more.");
            }
        }
    }
}
