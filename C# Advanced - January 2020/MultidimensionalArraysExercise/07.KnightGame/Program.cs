using System;
using System.Collections.Generic;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int rows = num;
            int cols = num;
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int count = 0;
            int finalCount = 0;
            int maxCount = 0;
            int maxCountIndexRow = 0;
            int maxCountIndexCol = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var element = matrix[r, c];
                    if (element == 'K')
                    {
                        if ((r - 2 >= 0 && c - 1 >= 0 && matrix[r - 2, c - 1] == 'K'))
                        {
                            count++;
                        }
                        if ((r - 2 >= 0 && c + 1 < cols && matrix[r - 2, c + 1] == 'K'))
                        {
                            count++;
                        }
                        if ((r + 2 < rows && c - 1 >= 0 && matrix[r + 2, c - 1] == 'K'))
                        {
                            count++;
                        }
                        if ((r + 2 < rows && c + 1 < cols && matrix[r + 2, c + 1] == 'K'))
                        {
                            count++;
                        }
                        if ((r + 1 < rows && c - 2 >= 0 && matrix[r + 1, c - 2] == 'K'))
                        {
                            count++;
                        }
                        if ((r - 1 >= 0 && c - 2 >= 0 && matrix[r - 1, c - 2] == 'K'))
                        {
                            count++;
                        }
                        if ((r + 1 < rows && c + 2 < cols && matrix[r + 1, c + 2] == 'K'))
                        {
                            count++;
                        }
                        if ((r - 1 >= 0 && c + 2 < cols && matrix[r - 1, c + 2] == 'K'))
                        {
                            count++;
                        }
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxCountIndexRow = r;
                        maxCountIndexCol = c;
                    }
                    if (maxCount == 0 && r == rows - 1 && c == cols - 1)
                    {
                        Console.WriteLine(finalCount);
                        return;
                    }
                    if (r == rows - 1 && c == cols - 1)
                    {
                        count = 0;
                        maxCount = 0;
                        matrix[maxCountIndexRow, maxCountIndexCol] = '0';
                        maxCountIndexRow = 0;
                        maxCountIndexCol = 0;
                        r = 0;
                        c = 0;
                        finalCount++;
                        continue;
                    }
                    count = 0;
                }
            }
            Console.WriteLine(count);
        }

        //static bool IsKnight(char[,] matrix, int r, int c)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix.GetLength(1);

        //    return
        //        r >= 0 && r < rows &&
        //        c >= 0 && c < cols &&
        //        matrix[r, c] == 'K';
        //}

        //static bool HasConflict(char[,] matrix, int r, int c)
        //{
        //    return
        //        IsKnight(matrix, r - 2, c - 1) ||
        //        IsKnight(matrix, r - 2, c + 1) ||
        //        IsKnight(matrix, r + 2, c - 1) ||
        //        IsKnight(matrix, r + 2, c + 1) ||
        //        IsKnight(matrix, r - 1, c - 2) ||
        //        IsKnight(matrix, r + 1, c - 2) ||
        //        IsKnight(matrix, r - 1, c + 2) ||
        //        IsKnight(matrix, r + 1, c + 2);
        //}

        //static int SolveKnightGame(char[,] matrix, int startR, int startC, int count, ref int minCount)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix.GetLength(1);

        //    for (int r = startR; r < rows; r++)
        //    {
        //        for (int c = startC; c < cols; c++)
        //        {
        //            var element = matrix[r, c];
        //            if (IsKnight(matrix, r, c))
        //            {
        //                if (HasConflict(matrix, r, c))
        //                {
        //                    matrix[r, c] = '0';
        //                    int newMin = SolveKnightGame(matrix, r, c + 1, count + 1, ref minCount);
        //                    if (newMin < minCount)
        //                    {
        //                        minCount = newMin;
        //                    }

        //                    matrix[r, c] = 'K';
        //                }
        //            }
        //        }

        //        startC = 0;
        //    }

        //    return count;
        //}
    }
}
