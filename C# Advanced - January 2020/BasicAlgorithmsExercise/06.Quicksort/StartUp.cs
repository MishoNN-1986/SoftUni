using System;
using System.Linq;

namespace _06.Quicksort
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == String.Empty)
            {
                return;
            }

            int[] arr = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            Quick.Sort(arr);

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
