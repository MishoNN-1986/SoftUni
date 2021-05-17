using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfSquareMatrix;
            int columns = sizeOfSquareMatrix;
            int[,] matrix = new int[rows, columns];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                int col = row;
                sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }
    }
}
