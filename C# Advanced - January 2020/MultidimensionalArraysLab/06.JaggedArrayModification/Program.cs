using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] matrix = new int[num, num];
            for (int row = 0; row < num; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < num; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (row < 0 || row >= num || col < 0 || col >= num)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    matrix[row, col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row, col] -= value;
                }
                input = Console.ReadLine();
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
