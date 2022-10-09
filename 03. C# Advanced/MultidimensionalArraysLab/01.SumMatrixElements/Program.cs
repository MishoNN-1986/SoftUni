using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ParseArrayFromConsole();
            int rows = input[0];
            int columns = input[1];
            int[,] matrix = new int[rows, columns];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = ParseArrayFromConsole();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int indexOfElements = col;
                    int element = elements[indexOfElements];
                    matrix[row, col] = element;
                    sum += element;
                }
            }
            Console.WriteLine($"{rows}\n{columns}\n{sum}");
        }

        private static int[] ParseArrayFromConsole()
            => Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

    }
}
