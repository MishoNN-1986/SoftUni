using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfSquareMatrix;
            int columns = sizeOfSquareMatrix;
            string[,] matrix = new string[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < columns; col++)
                {
                    string symbol = symbols[col].ToString();
                    matrix[row, col] = symbol;
                }
            }
            string findSymbol = Console.ReadLine();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    string element = matrix[row, col];
                    if (findSymbol == element)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{findSymbol} does not occur in the matrix ");
        }
    }
}
