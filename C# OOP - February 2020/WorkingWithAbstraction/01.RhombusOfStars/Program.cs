using System;

namespace _01.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                PrintRow(size, i);
            }
            for (int i = size - 1; i >= 1; i--)
            {
                PrintRow(size, i);
            }
        }

        private static void PrintRow(int size, int i)
        {
            for (int j = 0; j < size - i; j++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < i; col++)
            {
                Console.Write("* ");

            }
            Console.WriteLine("*");
        }
    }
}
