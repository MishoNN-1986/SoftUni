using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());
            char symbolTwo = char.Parse(Console.ReadLine());
            char symbolThree = char.Parse(Console.ReadLine());
            Console.WriteLine($"{symbolThree} {symbolTwo} {symbolOne}");
        }
    }
}
