using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilogramsLimons = double.Parse(Console.ReadLine());
            double kilogramsSugar = double.Parse(Console.ReadLine());
            double litersWater = double.Parse(Console.ReadLine());
            double allLiters = (kilogramsLimons * 980.0) + (kilogramsSugar * 0.3) + (litersWater * 1000.0);
            double quantityCups = Math.Floor(allLiters / 150.0);
            double winMoney = quantityCups * 1.2;
            Console.WriteLine($"All cups sold: {quantityCups}");
            Console.WriteLine($"Money earned: {winMoney:F2}");
        }
    }
}
