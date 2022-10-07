using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n && i < 10; i++)
            {
                for (int j = 1; j < n && j < 10; j++)
                {
                    for (int k = 1; k < n && k < 10; k++)
                    {
                        for (int l = 1; l < n && l < 10; l++)
                        {
                            if (i + j == k + l && n % (i + j) == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
