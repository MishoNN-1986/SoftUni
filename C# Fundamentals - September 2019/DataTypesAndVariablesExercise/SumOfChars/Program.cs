using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char alphabet = char.Parse(Console.ReadLine());
                sum += (int)alphabet;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
