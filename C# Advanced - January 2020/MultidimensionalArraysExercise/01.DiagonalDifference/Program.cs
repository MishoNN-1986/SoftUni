using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] matrix = new int[num, num];
            GetValuesInMatrix(num, matrix);
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int i = 0, j = num - 1; i < num; i++, j--)
            {
                primaryDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[j, i];
            }
            int diagonalDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(diagonalDifference);
        }

        private static void GetValuesInMatrix(int num, int[,] matrix)
        {
            for (int row = 0; row < num; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < num; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
    }
}
