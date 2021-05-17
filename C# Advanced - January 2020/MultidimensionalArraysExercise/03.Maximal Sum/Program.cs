using System;
using System.Linq;

namespace _03.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = GetParsedNumbers();
            int row = input[0];
            int cols = input[1];
            int[,] matrix = new int[row, cols];
            GetValuesInMatrix(row, cols, matrix);
            int maxSum = 0;
            int squareIndex = 3;
            int[,] elements = new int[squareIndex, squareIndex];
            int[,] maxElements = new int[squareIndex, squareIndex];
            for (int r = 0; r <= row - elements.GetLength(0); r++)
            {
                for (int c = 0; c <= cols - elements.GetLength(1); c++)
                {
                    int sum = 0;
                    for (int i = 0; i < squareIndex; i++)
                    {
                        for (int j = 0; j < squareIndex; j++)
                        {
                            elements[i, j] = matrix[r + i, c + j];
                            sum += elements[i, j];
                        }
                    }
                    if (sum > maxSum) // може да се запази макс позиция на row и cols и накрая да се вземат елементите
                    {
                        maxSum = sum;
                        for (int i = 0; i < squareIndex; i++)
                        {
                            for (int j = 0; j < squareIndex; j++)
                            {
                                maxElements[i, j] = elements[i, j];
                            }
                        }
                    }
                }
            }
            if (row >= squareIndex && cols >= squareIndex)
            {
                Console.WriteLine($"Sum = {maxSum}");
                for (int r = 0; r < squareIndex; r++)
                {
                    for (int c = 0; c < squareIndex; c++)
                    {
                        Console.Write($"{maxElements[r, c]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static int[] GetParsedNumbers()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        private static void GetValuesInMatrix(int row, int cols, int[,] matrix)
        {
            for (int r = 0; r < row; r++)
            {
                int[] rowsLine = GetParsedNumbers();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = rowsLine[c];
                }
            }
        }
    }
}
