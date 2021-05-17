using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>(Console.ReadLine().Split());
            int num = int.Parse(Console.ReadLine());
            while (people.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    people.Enqueue(people.Dequeue());
                }
                Console.WriteLine($"Removed {people.Dequeue()}");
            }
            Console.WriteLine($"Last is {people.Dequeue()}");
        }
    }
}
