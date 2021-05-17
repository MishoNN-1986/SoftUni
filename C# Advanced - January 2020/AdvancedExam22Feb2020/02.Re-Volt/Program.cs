using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            int playerRow = -1;
            int playerCol = -1;
            bool isWin = false;
            for (int row = 0; row < size; row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    string element = values[col].ToString();
                    matrix[row, col] = element;
                    if (element == "f")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            for (int i = 0; i < countOfCommands; i++)
            {
                int nexRow = playerRow;
                int nexCol = playerCol;
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (playerRow == 0)
                    {
                        nexRow = size - 1;
                    }
                    else
                    {
                        nexRow--;
                    }
                    if (matrix[nexRow, nexCol] == "B")
                    {
                        if (nexRow == 0)
                        {
                            nexRow = size - 1;
                        }
                        else
                        {
                            nexRow--;
                        }
                        if (matrix[nexRow, nexCol] == "T")
                        {
                            if (nexRow == size - 1)
                            {
                                nexRow = 0;
                            }
                            else
                            {
                                nexRow++;
                            }
                        }
                    }
                    else if (matrix[nexRow, nexCol] == "T")
                    {
                        if (nexRow == size - 1)
                        {
                            nexRow = 0;
                        }
                        else
                        {
                            nexRow++;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (playerRow == size - 1)
                    {
                        nexRow = 0;
                    }
                    else
                    {
                        nexRow++;
                    }
                    if (matrix[nexRow, nexCol] == "B")
                    {
                        if (nexRow == size - 1)
                        {
                            nexRow = 0;
                        }
                        else
                        {
                            nexRow++;
                        }
                        if (matrix[nexRow, nexCol] == "T")
                        {
                            if (nexRow == 0)
                            {
                                nexRow = size - 1;
                            }
                            else
                            {
                                nexRow--;
                            }
                        }
                    }
                    else if (matrix[nexRow, nexCol] == "T")
                    {
                        if (nexRow == 0)
                        {
                            nexRow = size - 1;
                        }
                        else
                        {
                            nexRow--;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (playerCol == 0)
                    {
                        nexCol = size - 1;
                    }
                    else
                    {
                        nexCol--;
                    }
                    if (matrix[nexRow, nexCol] == "B")
                    {
                        if (nexCol == 0)
                        {
                            nexCol = size - 1;
                        }
                        else
                        {
                            nexCol--;
                        }
                        if (matrix[nexRow, nexCol] == "T")
                        {
                            if (nexCol == size - 1)
                            {
                                nexCol = 0;
                            }
                            else
                            {
                                nexCol++;
                            }
                        }
                    }
                    else if (matrix[nexRow, nexCol] == "T")
                    {
                        if (nexCol == size - 1)
                        {
                            nexCol = 0;
                        }
                        else
                        {
                            nexCol++;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (playerCol == size - 1)
                    {
                        nexCol = 0;
                    }
                    else
                    {
                        nexCol++;
                    }
                    if (matrix[nexRow, nexCol] == "B")
                    {
                        if (nexCol == size - 1)
                        {
                            nexCol = 0;
                        }
                        else
                        {
                            nexCol++;
                        }
                        if (matrix[nexRow, nexCol] == "T")
                        {
                            if (nexCol == 0)
                            {
                                nexCol = size - 1;
                            }
                            else
                            {
                                nexCol--;
                            }
                        }
                    }
                    else if (matrix[nexRow, nexCol] == "T")
                    {
                        if (nexCol == 0)
                        {
                            nexCol = size - 1;
                        }
                        else
                        {
                            nexCol--;
                        }
                    }
                }
                if (matrix[nexRow, nexCol] == "F")
                {
                    matrix[playerRow, playerCol] = "-";
                    matrix[nexRow, nexCol] = "f";
                    Console.WriteLine("Player won!");
                    isWin = true;
                    break;
                }
                else
                {
                    matrix[playerRow, playerCol] = "-";
                    playerRow = nexRow;
                    playerCol = nexCol;
                    matrix[playerRow, playerCol] = "f";
                }
            }
            if (!isWin)
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(matrix, size);
        }

        private static void PrintMatrix(string[,] matrix, int size)
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
