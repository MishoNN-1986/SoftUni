using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = input[0];
            int cols = input[1];
            string[,] matrix = new string[row, cols];
            int squaresCount = 0;
            GetValuesInMatrix(row, cols, matrix);
            for (int r = 0; r < row - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1] && matrix[r + 1, c] == matrix[r + 1, c + 1]
                        && matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        squaresCount++;
                    }
                }
            }
            Console.WriteLine(squaresCount);
        }

        private static void GetValuesInMatrix(int row, int cols, string[,] matrix)
        {
            for (int r = 0; r < row; r++)
            {
                string[] rowsLine = Console.ReadLine().Split().ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = rowsLine[c];
                }
            }
        }
    }
}
