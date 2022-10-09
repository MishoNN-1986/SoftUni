using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[num][];
            for (long row = 0; row < num; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1; // [row][row]
            }
            for (long r = 1; r < pascalTriangle.Length; r++)
            {
                for (long c = 1; c < pascalTriangle[r].Length - 1; c++)
                {
                    long firstNumber = pascalTriangle[r - 1][c - 1];
                    long secondNumber = pascalTriangle[r - 1][c];
                    pascalTriangle[r][c] = firstNumber + secondNumber;
                }
            }
            foreach (var array in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
