using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
