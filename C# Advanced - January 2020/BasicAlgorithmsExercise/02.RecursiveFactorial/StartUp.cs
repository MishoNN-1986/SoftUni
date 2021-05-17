using System;

namespace _02.RecursiveFactorial
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        static long Factorial(int n)
        {
            if (n == 0) // базов случай(дъното на рекурсията)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
