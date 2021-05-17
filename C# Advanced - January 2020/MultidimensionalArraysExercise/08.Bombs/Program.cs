using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int row = num;
            int cols = num;
            int[,] matrix = new int[row, cols];
            GetValuesInMatrix(row, cols, matrix);
            string[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int aliveCells = 0;
            for (int i = 0; i < values.Length; i++)
            {
                string value = values[i];
                int rowIndex = int.Parse(value[0].ToString());
                int colIndex = int.Parse(value[2].ToString());
                int damage = matrix[rowIndex, colIndex];
                if (damage > 0)
                {
                    if (rowIndex == 0 && colIndex == 0)
                    {
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex + 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex == matrix.GetLength(0) - 1 && colIndex == 0)
                    {
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex + 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex == 0 && colIndex == matrix.GetLength(1) - 1)
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex - 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex == matrix.GetLength(0) - 1 && colIndex == matrix.GetLength(1) - 1)
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex - 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex == 0 && colIndex > 0 && colIndex < matrix.GetLength(1) - 1)
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex == matrix.GetLength(0) - 1 && colIndex > 0 && colIndex < matrix.GetLength(1) - 1)
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex > 0 && rowIndex < matrix.GetLength(0) - 1 && colIndex == 0)
                    {
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex + 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else if (rowIndex > 0 && rowIndex < matrix.GetLength(0) - 1 && colIndex == matrix.GetLength(1) - 1)
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex - 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                    else
                    {
                        if (matrix[rowIndex, colIndex - 1] > 0)
                        {
                            matrix[rowIndex, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex, colIndex + 1] > 0)
                        {
                            matrix[rowIndex, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex] > 0)
                        {
                            matrix[rowIndex - 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex] > 0)
                        {
                            matrix[rowIndex + 1, colIndex] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex - 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex - 1] -= damage;
                        }
                        if (matrix[rowIndex - 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex - 1, colIndex + 1] -= damage;
                        }
                        if (matrix[rowIndex + 1, colIndex + 1] > 0)
                        {
                            matrix[rowIndex + 1, colIndex + 1] -= damage;
                        }
                        matrix[rowIndex, colIndex] = 0;
                    }
                }
            }
            int sum = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int element = matrix[r, c];

                    if (element > 0)
                    {
                        aliveCells++;
                        sum += element;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(row, cols, matrix);
        }
        private static void PrintMatrix(int row, int cols, int[,] matrix)
        {
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
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

        private static int[] GetParsedNumbers()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}

