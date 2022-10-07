using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //брой числа
            int sumP1 = 0;                           // брой числа от 0 до 199
            int sumP2 = 0;                           // брой числа от 200 до 399  
            int sumP3 = 0;                            // брой числа от 400 до 599
            int sumP4 = 0;                            // брой числа от 600 до 799 
            int sumP5 = 0;                            // брой числа от 800 до 1000
            double p1 = 0.0;                           // процент числа 
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num < 200)
                {
                    sumP1++;
                }
                else if (num >= 200 && num < 400)
                {
                    sumP2++;
                }
                else if (num >= 400 && num < 600)
                {
                    sumP3++;
                }
                else if (num >= 600 && num < 800)
                {
                    sumP4++;
                }
                else if (num >= 800 && num <= 1000)
                {
                    sumP5++;
                }
            }
            p1 = (sumP1*1.0 / n) * 100;                       // процент числа 
            p2 = (sumP2*1.0 / n) * 100;
            p3 = (sumP3*1.0 / n) * 100;
            p4 = (sumP4*1.0 / n) * 100;
            p5 = (sumP5*1.0 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
