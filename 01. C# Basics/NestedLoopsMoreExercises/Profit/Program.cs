using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine());
            int twoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLeva; j++)
                {
                    for (int k = 0; k <= fiveLeva; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.Write($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
