using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            bool sum1AndSum2 = true;
            int maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum1 = num1 + num2;
                i++;
                if (i == n && n > 1 && sum1 != sum2)
                {
                    int diff = Math.Abs(sum1 - sum2);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                if (i < n)
                {
                    int num3 = int.Parse(Console.ReadLine());
                    int num4 = int.Parse(Console.ReadLine());
                    sum2 = num3 + num4;
                    if (sum2 != sum1)
                    {
                        sum1AndSum2 = false;
                        int diff = Math.Abs(sum1 - sum2);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                }
            }
            if (sum1AndSum2 == true)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
