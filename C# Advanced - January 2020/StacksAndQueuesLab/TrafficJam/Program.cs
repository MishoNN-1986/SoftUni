using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;
            while (car != "end")
            {
                if (car != "green")
                {
                    cars.Enqueue(car);
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (cars.Count > 0) //cars.Any()
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                car = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
