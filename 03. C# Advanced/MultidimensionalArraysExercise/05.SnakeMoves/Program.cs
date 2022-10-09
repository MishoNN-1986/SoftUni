using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = GetParsedNumbers();
            string snake = Console.ReadLine();
            int row = input[0];
            int cols = input[1];
            string[,] matrix = new string[row, cols];
            int startIndexLetterOfSnake = 0;
            for (int r = 0; r < row; r++)
            {
                if (r % 2 == 0)
                {
                    startIndexLetterOfSnake = GetRightRow(snake, cols, matrix, startIndexLetterOfSnake, r);
                }
                else
                {
                    startIndexLetterOfSnake = GetReverseRow(snake, cols, matrix, startIndexLetterOfSnake, r);
                }

            }
            PrintMatrix(row, cols, matrix);
        }

        private static void PrintMatrix(int row, int cols, string[,] matrix)
        {
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{matrix[r, c]}");
                }
                Console.WriteLine();
            }
        }

        private static int GetReverseRow(string snake, int cols, string[,] matrix, int startIndexLetterOfSnake, int r)
        {
            for (int c = cols - 1, s = startIndexLetterOfSnake; c >= 0; c--, s++)
            {
                if (s == snake.Length)
                {
                    s = 0;
                    startIndexLetterOfSnake = 0;
                }
                matrix[r, c] = snake[s].ToString();
                startIndexLetterOfSnake++;
            }

            return startIndexLetterOfSnake;
        }

        private static int GetRightRow(string snake, int cols, string[,] matrix, int startIndexLetterOfSnake, int r)
        {
            for (int c = 0, s = startIndexLetterOfSnake; c < cols; c++, s++)
            {
                if (s == snake.Length)
                {
                    s = 0;
                    startIndexLetterOfSnake = 0;
                }
                matrix[r, c] = snake[s].ToString();
                startIndexLetterOfSnake++;
            }

            return startIndexLetterOfSnake;
        }

        private static int[] GetParsedNumbers()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
