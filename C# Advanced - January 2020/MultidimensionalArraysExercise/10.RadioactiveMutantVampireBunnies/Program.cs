using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ReadFromConsole().Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            string[,] lair = new string[row, col];
            int playerIndexRow = 0;
            int playerIndexCol = 0;
            Queue<int> rowsBunniesIndexes = new Queue<int>();
            Queue<int> colsBunniesIndexes = new Queue<int>();
            for (int r = 0; r < row; r++)
            {
                string rowLine = Console.ReadLine();
                for (int c = 0; c < col; c++)
                {
                    lair[r, c] = rowLine[c].ToString();
                    if (rowLine[c].ToString() == "P")
                    {
                        playerIndexRow = r;
                        playerIndexCol = c;
                    }
                    else if (rowLine[c].ToString() == "B")
                    {
                        rowsBunniesIndexes.Enqueue(r);
                        colsBunniesIndexes.Enqueue(c);
                    }
                }
            }
            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {
                bool dead = false;
                bool win = false;
                string command = commands[i].ToString();
                if (command == "L")
                {
                    if (playerIndexCol == 0)
                    {
                        win = true;
                    }
                    else if (lair[playerIndexRow, playerIndexCol - 1] == "B")
                    {
                        dead = true;
                    }
                    lair[playerIndexRow, playerIndexCol] = ".";
                    if (!win)
                    {
                        playerIndexCol--;
                    }
                }
                else if (command == "R")
                {
                    if (playerIndexCol == col - 1)
                    {
                        win = true;
                    }
                    else if (lair[playerIndexRow, playerIndexCol + 1] == "B")
                    {
                        dead = true;
                    }
                    lair[playerIndexRow, playerIndexCol] = ".";
                    if (!win)
                    {
                        playerIndexCol++;
                    }
                }
                else if (command == "U")
                {
                    if (playerIndexRow == 0)
                    {
                        win = true;
                    }
                    else if (lair[playerIndexRow - 1, playerIndexCol] == "B")
                    {
                        dead = true;
                    }
                    lair[playerIndexRow, playerIndexCol] = ".";
                    if (!win)
                    {
                        playerIndexRow--;
                    }
                }
                else if (command == "D")
                {
                    if (playerIndexRow == row - 1)
                    {
                        win = true;
                    }
                    else if (lair[playerIndexRow + 1, playerIndexCol] == "B")
                    {
                        dead = true;
                    }
                    lair[playerIndexRow, playerIndexCol] = ".";
                    if (!win)
                    {
                        playerIndexRow++;
                    }
                    if (!win && !dead)
                    {
                        lair[playerIndexRow, playerIndexCol] = "P";
                    }
                }
                int countBunnies = rowsBunniesIndexes.Count;
                while (countBunnies != 0)
                {
                    int rowIndex = rowsBunniesIndexes.Dequeue();
                    int colIndex = colsBunniesIndexes.Dequeue();
                    if (rowIndex == 0)
                    {
                        if (colIndex == 0)
                        {
                            if (lair[rowIndex + 1, colIndex] != "B")
                            {
                                lair[rowIndex + 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex + 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                            if (lair[rowIndex, colIndex + 1] != "B")
                            {
                                lair[rowIndex, colIndex + 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex + 1);
                            }
                        }
                        else if (colIndex == col - 1)
                        {
                            if (lair[rowIndex + 1, colIndex] != "B")
                            {
                                lair[rowIndex + 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex + 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                            if (lair[rowIndex, colIndex - 1] != "B")
                            {
                                lair[rowIndex, colIndex - 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex - 1);
                            }
                        }
                        else
                        {
                            if (lair[rowIndex, colIndex - 1] != "B")
                            {
                                lair[rowIndex, colIndex - 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex - 1);
                            }
                            if (lair[rowIndex, colIndex + 1] != "B")
                            {
                                lair[rowIndex, colIndex + 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex + 1);
                            }
                            if (lair[rowIndex + 1, colIndex] != "B")
                            {
                                lair[rowIndex + 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex + 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                        }
                    }
                    else if (rowIndex == row - 1)
                    {
                        if (colIndex == 0)
                        {
                            if (lair[rowIndex - 1, colIndex] != "B")
                            {
                                lair[rowIndex - 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex - 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                            if (lair[rowIndex, colIndex + 1] != "B")
                            {
                                lair[rowIndex, colIndex + 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex + 1);
                            }
                        }
                        else if (colIndex == col - 1)
                        {
                            if (lair[rowIndex - 1, colIndex] != "B")
                            {
                                lair[rowIndex - 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex - 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                            if (lair[rowIndex, colIndex - 1] != "B")
                            {
                                lair[rowIndex, colIndex - 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex - 1);
                            }
                        }
                        else
                        {
                            if (lair[rowIndex, colIndex - 1] != "B")
                            {
                                lair[rowIndex, colIndex - 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex - 1);
                            }
                            if (lair[rowIndex, colIndex + 1] != "B")
                            {
                                lair[rowIndex, colIndex + 1] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex);
                                colsBunniesIndexes.Enqueue(colIndex + 1);
                            }
                            if (lair[rowIndex - 1, colIndex] != "B")
                            {
                                lair[rowIndex - 1, colIndex] = "B";
                                rowsBunniesIndexes.Enqueue(rowIndex - 1);
                                colsBunniesIndexes.Enqueue(colIndex);
                            }
                        }
                    }
                    else if (colIndex == 0)
                    {
                        if (lair[rowIndex, colIndex + 1] != "B")
                        {
                            lair[rowIndex, colIndex + 1] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex);
                            colsBunniesIndexes.Enqueue(colIndex + 1);
                        }
                        if (lair[rowIndex - 1, colIndex] != "B")
                        {
                            lair[rowIndex - 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex - 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                        if (lair[rowIndex + 1, colIndex] != "B")
                        {
                            lair[rowIndex + 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex + 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                    }
                    else if (colIndex == col - 1)
                    {
                        if (lair[rowIndex, colIndex - 1] != "B")
                        {
                            lair[rowIndex, colIndex - 1] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex);
                            colsBunniesIndexes.Enqueue(colIndex - 1);
                        }
                        if (lair[rowIndex - 1, colIndex] != "B")
                        {
                            lair[rowIndex - 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex - 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                        if (lair[rowIndex + 1, colIndex] != "B")
                        {
                            lair[rowIndex + 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex + 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                    }
                    else
                    {
                        if (lair[rowIndex, colIndex - 1] != "B")
                        {
                            lair[rowIndex, colIndex - 1] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex);
                            colsBunniesIndexes.Enqueue(colIndex - 1);
                        }
                        if (lair[rowIndex - 1, colIndex] != "B")
                        {
                            lair[rowIndex - 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex - 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                        if (lair[rowIndex + 1, colIndex] != "B")
                        {
                            lair[rowIndex + 1, colIndex] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex + 1);
                            colsBunniesIndexes.Enqueue(colIndex);
                        }
                        if (lair[rowIndex, colIndex + 1] != "B")
                        {
                            lair[rowIndex, colIndex + 1] = "B";
                            rowsBunniesIndexes.Enqueue(rowIndex);
                            colsBunniesIndexes.Enqueue(colIndex + 1);
                        }
                    }
                    countBunnies--;
                }
                if (lair[playerIndexRow, playerIndexCol] == "B")
                {
                    dead = true;
                }
                if (win)
                {
                    PlayerWin(row, col, lair, playerIndexRow, playerIndexCol);
                    return;
                }
                else if (dead)
                {
                    PlayerDead(row, col, lair, playerIndexRow, playerIndexCol);
                    return;
                }
            }
        }

        private static void PlayerDead(int row, int col, string[,] lair, int playerIndexRow, int playerIndexCol)
        {
            PrintLair(row, col, lair);
            Console.WriteLine($"dead: {playerIndexRow} {playerIndexCol}");
        }

        private static void PlayerWin(int row, int col, string[,] lair, int playerIndexRow, int playerIndexCol)
        {
            PrintLair(row, col, lair);
            Console.WriteLine($"won: {playerIndexRow} {playerIndexCol}");
        }

        private static void PrintLair(int row, int col, string[,] lair)
        {
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(string.Join("", lair[r, c]));
                }
                Console.WriteLine();
            }
        }

        private static string[] ReadFromConsole()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
