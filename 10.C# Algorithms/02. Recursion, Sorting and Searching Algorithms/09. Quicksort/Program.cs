﻿using System;
using System.Linq;

namespace _09._Quicksort
{
    class Program
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
