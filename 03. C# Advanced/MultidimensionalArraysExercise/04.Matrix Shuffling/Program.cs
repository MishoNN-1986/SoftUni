using System;
using System.Linq;

namespace _04.Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = GetParsedInput().Select(int.Parse).ToArray();
            int row = input[0];
            int cols = input[1];
            string[,] matrix = new string[row, cols];
            GetValuesInMatrix(row, cols, matrix);
            string commands = Console.ReadLine();
            while (commands != "END")
            {
                string[] splitCommands = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (splitCommands[0] != "swap" || splitCommands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string command = splitCommands[0];
                    int firstRow = int.Parse(splitCommands[1]);
                    int firstCol = int.Parse(splitCommands[2]);
                    int secondRow = int.Parse(splitCommands[3]);
                    int secondCol = int.Parse(splitCommands[4]);
                    if (firstRow >= 0 && firstRow < row && secondRow >= 0 && secondRow < row &&
                        firstCol >= 0 && firstCol < cols && secondCol >= 0 && secondCol < cols)
                    {
                        string firstInput = matrix[firstRow, firstCol];
                        string secondInput = matrix[secondRow, secondCol];
                        matrix[firstRow, firstCol] = secondInput;
                        matrix[secondRow, secondCol] = firstInput;
                        PrintChangeMatrix(row, cols, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                commands = Console.ReadLine();
            }
        }

        private static void PrintChangeMatrix(int row, int cols, string[,] matrix)
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

        private static string[] GetParsedInput()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        private static void GetValuesInMatrix(int row, int cols, string[,] matrix)
        {
            for (int r = 0; r < row; r++)
            {
                string[] rowsLine = GetParsedInput();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = rowsLine[c].ToString();
                }
            }
        }
    }
}
