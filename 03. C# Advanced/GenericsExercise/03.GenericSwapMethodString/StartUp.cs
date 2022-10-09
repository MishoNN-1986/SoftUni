using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            Box<string> box = new Box<string>(list);
            int[] indexes = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
               Select(int.Parse).
               ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
