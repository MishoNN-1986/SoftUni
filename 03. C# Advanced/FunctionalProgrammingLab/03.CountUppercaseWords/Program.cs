using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => char.IsUpper(word[0]))
                .ToList()
                .ForEach(Console.WriteLine); //ForEach не връща нищо, за това започваме с Console.ReadLine()
        }
    }
}
