using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            {
                Console.WriteLine(string.Join(" ", arr));
            };

            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Reverse()
                 .ToArray();

            int number = int.Parse(Console.ReadLine());

            Func<int[], int[]> processor = Exclude(number);
            numbers = processor(numbers);
            print(numbers);
        }

        static Func<int[], int[]> Exclude(int number)
        {
            Func<int[], int[]> processor = null;
            processor = new Func<int[], int[]>((arr) =>
             {
                 return arr.Where(n => n % number != 0).ToArray();
             });
            return processor;
        }
    }
}
