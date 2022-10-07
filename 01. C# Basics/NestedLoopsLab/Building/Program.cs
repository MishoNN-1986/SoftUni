using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumFloor = int.Parse(Console.ReadLine());
            int sumRoom = int.Parse(Console.ReadLine());

            for (int i = sumFloor; i > 0; i--)
            {
                for (int j = 0; j < sumRoom; j++)
                {
                    if (i == sumFloor)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
