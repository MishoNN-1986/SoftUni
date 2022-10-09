using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            string car = string.Empty;
            int totalCarsPassed = 0;
            while (command != "END")
            {
                if (command != "green")
                {
                    car = command;
                    cars.Enqueue(car);
                }
                else
                {
                    if (cars.Any())
                    {
                        int secondsLeft = greenLightSeconds;
                        for (int i = 0; i < cars.Count; i++)
                        {
                            car = cars.Dequeue();
                            secondsLeft -= car.Length;
                            totalCarsPassed++;
                            if (secondsLeft == 0)
                            {
                                break;
                            }
                            if (secondsLeft < 0)
                            {
                                secondsLeft += freeWindowSeconds;
                                if (secondsLeft >= 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    char hitChar = car[car.Length + secondsLeft];
                                    Console.WriteLine($"{car} was hit at {hitChar}.");
                                    return;
                                }
                            }
                            i--;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
