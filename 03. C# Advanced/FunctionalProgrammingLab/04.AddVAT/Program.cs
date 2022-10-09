using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        public static object UnaryOperator { get; private set; }

        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => $"{x * 1.2:F2}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
