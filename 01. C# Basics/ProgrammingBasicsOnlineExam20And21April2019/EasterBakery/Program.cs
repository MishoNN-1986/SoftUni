using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOneKilogramFlour = double.Parse(Console.ReadLine());
            double quantityKilogramsFlour = double.Parse(Console.ReadLine());
            double quantityKilogramsSugar = double.Parse(Console.ReadLine());
            int sumEggCrust = int.Parse(Console.ReadLine());
            int sumMayPackages = int.Parse(Console.ReadLine());
            double allSum = (priceForOneKilogramFlour * quantityKilogramsFlour) + (priceForOneKilogramFlour * 0.75 * quantityKilogramsSugar) + (priceForOneKilogramFlour * 1.1 * sumEggCrust) + (priceForOneKilogramFlour * 0.75 * 0.2 * sumMayPackages);
            Console.WriteLine($"{allSum:F2}");
        }
    }
}
