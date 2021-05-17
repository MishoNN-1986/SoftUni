using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            string[] symbolsToArray = symbols.Split();
            for (int i = symbolsToArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{symbolsToArray[i]} ");
            }
        }
    }
}
