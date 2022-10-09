using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNames = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            for (int i = 0; i < quantityNames; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }
            foreach (var name in uniqueNames)  // може и със string.Join
            {
                Console.WriteLine(name);
            }
        }
    }
}
