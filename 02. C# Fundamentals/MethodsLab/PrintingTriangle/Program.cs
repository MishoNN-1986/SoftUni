﻿using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingTriangle(int.Parse(Console.ReadLine()));
        }
        static void PrintingTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
