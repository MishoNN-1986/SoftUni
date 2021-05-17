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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int volumeOfTheApartment = a * b * h;
            int freePlace = 0;
            int sumCarton = 0;
            int volumeOfTheCarton = 1;
            while (freePlace >= 0)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{freePlace} Cubic meters left.");
                    break;
                }
                else
                {
                    sumCarton += int.Parse(command);
                    freePlace = volumeOfTheApartment - sumCarton;
                }
            }
            if (freePlace < 0)
            {
                int needPlace = sumCarton - volumeOfTheApartment;
                Console.WriteLine($"No more free space! You need {needPlace} Cubic meters more.");
            }

        }
    }
}
