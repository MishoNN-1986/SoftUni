using System;

namespace BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            var mask = 1 << position;
            mask = ~mask;
            var result = num & mask;
            Console.WriteLine(result);
        }
    }
}
