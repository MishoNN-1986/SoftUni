using System;
using System.Numerics;

namespace BigFactorialBigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
