using System;

namespace TriBitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            long mask = (long)7L << p;
            long result = n ^ mask;
            Console.WriteLine(result);
        }
    }
}
