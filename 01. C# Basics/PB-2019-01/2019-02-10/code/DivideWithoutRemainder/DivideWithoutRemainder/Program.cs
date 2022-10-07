using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumP1 = 0.0;
            double sumP2 = 0.0;
            double sumP3 = 0.0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)                // polzwame samo if, zashtoto moje nqkoe chislo da se deli na poveche ot 1 if
                {
                    sumP1++;
                }
                if (num % 3 == 0)
                {
                    sumP2++;
                }
                if (num % 4 == 0)
                {
                    sumP3++;
                }
            }
            p1 = (sumP1 * 1.0 / n) * 100;
            p2 = (sumP2 * 1.0 / n) * 100;
            p3 = (sumP3 * 1.0 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
