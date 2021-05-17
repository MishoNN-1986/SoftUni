using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = new Action<string>((name) =>
            {
                Console.WriteLine($"Sir {name}");
            });
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList().
                ForEach(honor); // може и на 1 ред като в скобите се пише вместо honor, Action<string> honor = new Action<string>((name) => ...., но е тегаво за дебъдване
        }
    }
}
