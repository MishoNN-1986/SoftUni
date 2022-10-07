using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int sumRowInFirstSector = int.Parse(Console.ReadLine());
            int numberOfSeats = int.Parse(Console.ReadLine());
            int count = 0;
            for (char i = 'A'; i <= lastSector; i++, sumRowInFirstSector++)
            {
                for (int j = 1; j <= sumRowInFirstSector; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k < 'a' + numberOfSeats + 2; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count++;
                        }
                    }
                    else
                    {
                        for (char k = 'a'; k < 'a' + numberOfSeats; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
