﻿using System;
using System.Linq;

namespace _07.BinarySearch
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int key = int.Parse(Console.ReadLine());

            if (input == String.Empty)
            {
                return;
            }

            int[] arr = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = BinarySearch.IndexOf(arr, key);
            Console.WriteLine(index);
        }
    }
}
