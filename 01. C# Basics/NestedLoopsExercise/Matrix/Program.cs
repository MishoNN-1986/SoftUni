using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int ad = a + d;
            int bc = b + c;
            for (int x1 = a; x1 <= b; x1++)
            {
                for (int x2 = a; x2 <= b; x2++)  // слагаме int x2 = a; x2 <= b; x2++ , защото х2 е по-голямо от х1, а искаме да ни даде числата от по-малкото към по-голямото
                {
                    for (int x3 = c; x3 <= d; x3++)
                    {
                        for (int x4 = d; x4 >= c; x4--)
                        {
                            if (x1 == x2 || x3 == x4)
                            {
                                continue;
                            }
                            if (x1 + x4 == x2 + x3)
                            {
                                Console.WriteLine($"{x1}{x2}");
                                Console.WriteLine($"{x3}{x4}");
                                Console.WriteLine();
                                //Console.WriteLine($"{x2}{x1}");
                                //Console.WriteLine($"{x4}{x3}");
                                //Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
