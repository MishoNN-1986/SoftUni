using System;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[,] field = new string[fieldSize, fieldSize];
            string[] commands = ReadFromConsole();
            int startIndexRow = 0;
            int startIndexCol = 0;
            int allCoals = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] input = ReadFromConsole();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                    if (input[col] == "s")
                    {
                        startIndexRow = row;
                        startIndexCol = col;
                    }
                    else if (input[col] == "c")
                    {
                        allCoals++;
                    }
                }
            }
            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                if (command == "left")
                {
                    startIndexCol = MoveStartIndexToLeft(startIndexCol);
                }
                else if (command == "right")
                {
                    startIndexCol = MoveStartIndexToRight(field, startIndexCol);
                }
                else if (command == "up")
                {
                    startIndexRow = MoveStartIndexToUp(startIndexRow);
                }
                else if (command == "down")
                {
                    startIndexRow = MoveStartIndexToDown(field, startIndexRow);
                }
                if (field[startIndexRow, startIndexCol] == "c")
                {
                    allCoals--;
                    field[startIndexRow, startIndexCol] = "*";
                    if (allCoals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startIndexRow}, {startIndexCol})");
                        return;
                    }
                }
                else if (field[startIndexRow, startIndexCol] == "e")
                {
                    Console.WriteLine($"Game over! ({startIndexRow}, {startIndexCol})");
                    return;
                }
            }
            Console.WriteLine($"{allCoals} coals left. ({startIndexRow}, {startIndexCol})");
        }

        private static int MoveStartIndexToDown(string[,] field, int startIndexRow)
        {
            if (startIndexRow < field.GetLength(0) - 1)
            {
                startIndexRow++;
            }

            return startIndexRow;
        }

        private static int MoveStartIndexToUp(int startIndexRow)
        {
            if (startIndexRow > 0)
            {
                startIndexRow--;
            }

            return startIndexRow;
        }

        private static int MoveStartIndexToRight(string[,] field, int startIndexCol)
        {
            if (startIndexCol < field.GetLength(1) - 1)
            {
                startIndexCol++;
            }

            return startIndexCol;
        }

        private static int MoveStartIndexToLeft(int startIndexCol)
        {
            if (startIndexCol > 0)
            {
                startIndexCol--;
            }

            return startIndexCol;
        }

        private static string[] ReadFromConsole()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
