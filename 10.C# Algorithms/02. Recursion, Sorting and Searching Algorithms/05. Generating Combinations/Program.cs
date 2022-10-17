﻿using System;
using System.Linq;

namespace _05._Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = int.Parse(Console.ReadLine());
            int[] vector = new int[count];

            GenCombs(set, vector, 0, 0);
        }

        private static void GenCombs(int[] set, int[] vector, int index, int border)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
                return;
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenCombs(set, vector, index + 1, i + 1);
                }
            }
        }
    }
}
