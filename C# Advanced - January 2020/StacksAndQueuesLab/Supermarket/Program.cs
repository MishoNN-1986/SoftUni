using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            while (name != "End")
            {
                if (name == "Paid")
                {
                    foreach (var people in names)
                    {
                        Console.WriteLine(people);
                    }
                    names.Clear();
                }
                else
                {
                    names.Enqueue(name);
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
