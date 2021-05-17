using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            Box<int> box = new Box<int>(list);
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
