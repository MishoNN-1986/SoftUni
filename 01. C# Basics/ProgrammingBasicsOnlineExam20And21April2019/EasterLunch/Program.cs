using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggCrust = int.Parse(Console.ReadLine());
            int kilogramsCookies = int.Parse(Console.ReadLine());
            double allSum = easterBread * 3.20 + eggCrust * 4.35 + eggCrust * 12.0 * 0.15 + kilogramsCookies * 5.4;
            Console.WriteLine($"{allSum:F2}");
        }
    }
}
