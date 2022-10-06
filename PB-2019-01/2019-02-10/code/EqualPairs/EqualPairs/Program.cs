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
            int n = int.Parse(Console.ReadLine()); // брой двойки числа
            int currSum = 0;                        //текуща сума
            int prevSum = 0;                        // предишна сума
            int diff = 0;                           // разлика
            int maxDiff = 0;                        // максимална разлика
            for (int i = 0; i < n; i++)
            {
                prevSum = currSum;
                currSum = 0;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                currSum = a + b;
                if (i != 0)
                {
                    diff = Math.Abs(currSum - prevSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
            if (prevSum == currSum || n == 1)
            {
                Console.WriteLine($"Yes, value={currSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
