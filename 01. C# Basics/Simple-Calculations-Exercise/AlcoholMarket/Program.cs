using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForWhisky = double.Parse(Console.ReadLine());
            double litersBeers = double.Parse(Console.ReadLine());
            double litersWine = double.Parse(Console.ReadLine());
            double litersRakia = double.Parse(Console.ReadLine());
            double litersWhisky = double.Parse(Console.ReadLine());
            double allSum = priceForWhisky * litersWhisky + litersRakia * priceForWhisky / 2 + litersWine * priceForWhisky / 2 * 0.6 + litersBeers * priceForWhisky / 2 * 0.2;
            Console.WriteLine($"{allSum:F2}");





        }
    }
}
