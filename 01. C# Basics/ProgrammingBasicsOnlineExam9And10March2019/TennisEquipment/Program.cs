using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tennisRacket = decimal.Parse(Console.ReadLine());
            int sumTennisRackets = int.Parse(Console.ReadLine());
            int sneakers = int.Parse(Console.ReadLine());
            var a = tennisRacket * 1m * sumTennisRackets;
            var b = 1m / 6m * tennisRacket;
            var c = sneakers * b;
            var d = a + c;
            decimal allSum = d * 1.2m;

            decimal sponsors = Math.Ceiling(allSum * 7m / 8m);
            decimal djokovic = Math.Floor(allSum / 8m);
            
            Console.WriteLine($"Price to be paid by Djokovic {djokovic}");
            Console.WriteLine($"Price to be paid by sponsors {sponsors}");
        }
    }
}
