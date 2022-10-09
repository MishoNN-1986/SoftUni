using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ParseArrayFromConsole();
            int rows = input[0];
            int columns = input[1];
            int[,] matrix = new int[rows, columns];
            int maxSum = int.MinValue;
            int[,] square = new int[2, 2];
            int[,] maxNum = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = ParseArrayFromConsole();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int indexOfElements = col;
                    int element = elements[indexOfElements];
                    matrix[row, col] = element;
                }
            }
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {
                    int sum = 0;
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = col; j < col + 2; j++)
                        {
                            sum += matrix[i, j];
                            square[i - row, j - col] = matrix[i, j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        for (int r = 0; r < 2; r++)
                        {
                            for (int c = 0; c < 2; c++)
                            {
                                maxNum[r, c] = square[r, c];
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{maxNum[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }

        private static int[] ParseArrayFromConsole()
            => Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
    }
}
