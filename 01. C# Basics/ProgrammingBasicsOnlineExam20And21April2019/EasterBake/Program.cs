using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEasterBake = int.Parse(Console.ReadLine());
            int maxSugar = 0;
            int maxFlour = 0;
            int countSugar = 0;
            int countFlour = 0;
            for (int i = 0; i < sumEasterBake; i++)
            {
                int quantitySugar = int.Parse(Console.ReadLine());
                int quantityFlour = int.Parse(Console.ReadLine());
                if (quantitySugar > maxSugar)
                {
                    maxSugar = quantitySugar;
                }
                if (quantityFlour > maxFlour)
                {
                    maxFlour = quantityFlour;
                }
                countSugar += quantitySugar;
                countFlour += quantityFlour;
            }
            Console.WriteLine($"Sugar: {Math.Ceiling(countSugar / 950.0)}");
            Console.WriteLine($"Flour: {Math.Ceiling(countFlour / 750.0)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
