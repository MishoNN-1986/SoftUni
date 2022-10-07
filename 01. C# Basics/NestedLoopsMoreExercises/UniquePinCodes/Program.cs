using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num1; i += 2)
            {
                for (int k = 2; k <= num2; k++)
                {
                    if (k != 2 && k != 3 && k != 5 && k != 7)
                    {
                        continue;
                    }
                    for (int l = 2; l <= num3; l += 2)
                    {
                        Console.WriteLine($"{i} {k} {l}");
                    }
                }
            }
        }
    }
}
