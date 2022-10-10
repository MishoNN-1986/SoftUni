using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dimensions = SplitInputToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            long sum = 0;

            string command = Console.ReadLine();
            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinates = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] evilPowerCoordinates = SplitInputToArray();

                MoveEvil(matrix, evilPowerCoordinates);

                sum = MoveIvo(matrix, sum, ivoCoordinates);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static long MoveIvo(int[,] matrix, long sum, int[] ivoCoordinates)
        {
            int ivosRow = ivoCoordinates[0];
            int ivosCol = ivoCoordinates[1];

            while (ivosRow >= 0 && ivosCol < matrix.GetLength(1))
            {
                if (IsInside(matrix, ivosRow, ivosCol))
                {
                    sum += matrix[ivosRow, ivosCol];
                }

                ivosRow--;
                ivosCol++;
            }

            return sum;
        }

        private static void MoveEvil(int[,] matrix, int[] evilPowerCoordinates)
        {
            int evilRow = evilPowerCoordinates[0];
            int evilCol = evilPowerCoordinates[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (IsInside(matrix, evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0; ;
                }

                evilRow--;
                evilCol--;
            }
        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

        private static int[] SplitInputToArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static void FillMatrix(int[,] matrix)
        {
            int starValue = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = starValue++;
                }
            }
        }
    }
}
