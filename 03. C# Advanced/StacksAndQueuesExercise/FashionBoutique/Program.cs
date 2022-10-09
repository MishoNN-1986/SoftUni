using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int countRack = 0;
            int sum = 0;
            while (clothes.Any())
            {
                while (sum <= capacity && clothes.Any())
                {
                    if (sum + clothes.Peek() <= capacity)
                    {
                        sum += clothes.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                countRack++;
                sum = 0;
            }
            Console.WriteLine(countRack);
        }
    }
}
