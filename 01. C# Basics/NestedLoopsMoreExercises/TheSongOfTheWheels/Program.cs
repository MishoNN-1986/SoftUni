using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            string password = "";
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == num && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                count++;
                                if (count == 4)
                                {
                                    password = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }
            if (count < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {password}");
            }
        }
    }
}
