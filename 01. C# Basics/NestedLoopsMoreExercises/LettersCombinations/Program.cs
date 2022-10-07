using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = first; i <= second; i++)
            {
                if (i == third)
                {
                    continue;
                }
                for (char j = first; j <= second; j++)
                {
                    if (j == third)
                    {
                        continue;
                    }
                    for (char k = first; k <= second; k++)
                    {
                        if (k == third)
                        {
                            continue;
                        }
                        count++;
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
            Console.Write(count);
            Console.WriteLine();
        }
    }
}
