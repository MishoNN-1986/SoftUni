using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countDivision2 = 0;
            int countDivision3 = 0;
            int countDivision4 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    countDivision2++;
                }
                if (num % 3 == 0)
                {
                    countDivision3++;
                }
                if (num % 4 == 0)
                {
                    countDivision4++;
                }
            }
            double p1 = countDivision2 * 1.0 / n * 100.0;
            double p2 = countDivision3 * 1.0 / n * 100.0;
            double p3 = countDivision4 * 1.0 / n * 100.0;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
