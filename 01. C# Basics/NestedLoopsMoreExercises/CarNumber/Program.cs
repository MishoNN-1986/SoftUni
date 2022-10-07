using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int l = num1; l <= num2; l++)
                        {
                            if (((i % 2 == 0 && l % 2 == 1) || (i % 2 == 1 && l % 2 == 0)) && (i > l) && ((j + k) % 2 == 0))
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
