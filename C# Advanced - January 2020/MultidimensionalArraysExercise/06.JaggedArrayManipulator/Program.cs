using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double[][] matrix = new double[num][];
            for (int row = 0; row < num; row++)
            {
                double[] col = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[row] = col;
            }
            for (int row = 0; row < num - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int c = 0; c < matrix[row].Length; c++)
                    {
                        matrix[row][c] = matrix[row][c] * 2;
                        matrix[row + 1][c] = matrix[row + 1][c] * 2;
                    }
                }
                else
                {
                    for (int c = 0; c < matrix[row].Length; c++)
                    {
                        matrix[row][c] = matrix[row][c] / 2;
                    }
                    for (int c = 0; c < matrix[row + 1].Length; c++)
                    {
                        matrix[row + 1][c] = matrix[row + 1][c] / 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string operation = splitCommand[0];
                if (splitCommand.Length == 4)
                {
                    int row = int.Parse(splitCommand[1]);
                    int col = int.Parse(splitCommand[2]);
                    int value = int.Parse(splitCommand[3]);
                    if (row >= 0 && row < num && col >= 0 && col < matrix[row].Length)
                    {
                        if (operation == "Add")
                        {
                            matrix[row][col] += value;
                        }
                        else if (operation == "Subtract")
                        {
                            matrix[row][col] -= value;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            for (int r = 0; r < num; r++)
            {
                Console.WriteLine(string.Join(" ", matrix[r]));
            }
        }
    }
}
