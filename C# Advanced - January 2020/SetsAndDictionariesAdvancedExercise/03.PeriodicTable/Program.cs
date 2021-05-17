using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < lines; i++)
            {
                string[] inputElements = Console.ReadLine().Split();
                for (int j = 0; j < inputElements.Length; j++)
                {
                    string element = inputElements[j];
                    elements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
