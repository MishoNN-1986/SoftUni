using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> output = new Stack<char>();  // може и в скобите input, и директно го взима в стека
            for (int i = 0; i < input.Length; i++)  
            {
                char symbol = input[i];
                output.Push(symbol);
            }
            foreach (var item in output)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
