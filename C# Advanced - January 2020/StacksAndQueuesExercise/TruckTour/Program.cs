using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<int> neededPetrol = new Queue<int>();
            int petrol = 0;
            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                petrol = input[0] - input[1];
                neededPetrol.Enqueue(petrol);
            }
            bool noPetrol = false;
            for (int i = 0; i < neededPetrol.Count; i++)
            {
                noPetrol = false;
                if (neededPetrol.Peek() < 0)
                {
                    neededPetrol.Enqueue(neededPetrol.Dequeue());
                }
                else
                {
                    int sum = 0;
                    foreach (var item in neededPetrol)
                    {
                        sum += item;
                        if (sum < 0)
                        {
                            noPetrol = true;
                        }
                    }
                    if (!noPetrol)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    else
                    {
                        neededPetrol.Enqueue(neededPetrol.Dequeue());
                    }
                }
            }
        }
    }
}
