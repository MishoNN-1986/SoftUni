using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairs = int.Parse(Console.ReadLine());
            int secondPairs = int.Parse(Console.ReadLine());
            int diffFirstPairs = int.Parse(Console.ReadLine());
            int diffSecondPairs = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = firstPairs; i <= firstPairs + diffFirstPairs; i++)
            {
                for (int j = secondPairs; j <= secondPairs + diffSecondPairs; j++)
                {
                    for (int l = 2; l <= i; l++)
                    {
                        for (int k = 2; k <= j; k++)
                        {
                            if (j % k == 0 && i % l == 0)
                            {
                                count++;
                            }
                        }
                        //count = 0;
                    }
                    if (count == 1)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    count = 0;
                }
            }
        }
    }
}
