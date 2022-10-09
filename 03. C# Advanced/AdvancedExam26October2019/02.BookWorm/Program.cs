using System;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            int playerPositionRow = 0;
            int playerPositionCol = 0;
            for (int row = 0; row < size; row++) //вместо size може (matrix.GetLength(0))
            {
                string elements = Console.ReadLine();
                for (int col = 0; col < size; col++) // (1)
                {
                    int indexOfElement = col;
                    string element = elements[indexOfElement].ToString();
                    matrix[row, col] = element;
                    if (element == "P")
                    {
                        playerPositionRow = row;
                        playerPositionCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                bool punish = false;
                if (command == "up")
                {
                    if (playerPositionRow == 0)
                    {
                        punish = true;
                    }
                    else
                    {
                        char nexElement = char.Parse(matrix[playerPositionRow - 1, playerPositionCol]);
                        if (char.IsLetter(nexElement))
                        {
                            initial += nexElement;
                        }
                        matrix[playerPositionRow, playerPositionCol] = "-";
                        playerPositionRow--;
                    }
                }
                else if (command == "down")
                {
                    if (playerPositionRow == size - 1)
                    {
                        punish = true;
                    }
                    else
                    {
                        char nexElement = char.Parse(matrix[playerPositionRow + 1, playerPositionCol]);
                        if (char.IsLetter(nexElement))
                        {
                            initial += nexElement;
                        }
                        matrix[playerPositionRow, playerPositionCol] = "-";
                        playerPositionRow++;
                    }
                }
                else if (command == "left")
                {
                    if (playerPositionCol == 0)
                    {
                        punish = true;
                    }
                    else
                    {
                        char nexElement = char.Parse(matrix[playerPositionRow, playerPositionCol - 1]);
                        if (char.IsLetter(nexElement))
                        {
                            initial += nexElement;
                        }
                        matrix[playerPositionRow, playerPositionCol] = "-";
                        playerPositionCol--;
                    }
                }
                else if (command == "right")
                {
                    if (playerPositionCol == size - 1)
                    {
                        punish = true;
                    }
                    else
                    {
                        char nexElement = char.Parse(matrix[playerPositionRow, playerPositionCol + 1]);
                        if (char.IsLetter(nexElement))
                        {
                            initial += nexElement;
                        }
                        matrix[playerPositionRow, playerPositionCol] = "-";
                        playerPositionCol++;
                    }
                }
                if (punish)
                {
                    if (initial.Length > 0)
                    {
                        initial = initial.Remove(initial.Length - 1);
                    }
                }
                else
                {
                    matrix[playerPositionRow, playerPositionCol] = "P";
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(initial);
            PrintMatrix(size, matrix);
        }

        private static void PrintMatrix(int size, string[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
