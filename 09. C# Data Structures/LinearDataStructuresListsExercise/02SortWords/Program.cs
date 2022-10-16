using System;
using System.Linq;

namespace _02SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .OrderBy(x => x);

            Console.WriteLine(string.Join(" ", inputWords));

        }
    }
}
