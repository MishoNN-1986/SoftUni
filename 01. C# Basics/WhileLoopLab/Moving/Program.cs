using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;
            int count = 0;
            while (count < volume)
            {
                string sumCarton = Console.ReadLine();
                if (sumCarton == "Done")
                {
                    int difference = volume - count;
                    Console.WriteLine($"{difference} Cubic meters left.");
                    break;
                }
                else
                {
                    int sumCartonInInt = int.Parse(sumCarton);
                    count += sumCartonInInt;
                    int needMeters = count - volume;
                    if (needMeters >= 0)
                    {
                        Console.WriteLine($"No more free space! You need {needMeters} Cubic meters more.");
                    }
                }
            }
        }
    }
}
