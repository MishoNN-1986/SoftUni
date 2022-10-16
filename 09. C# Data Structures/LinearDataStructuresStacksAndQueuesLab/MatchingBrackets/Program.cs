using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                string currentSymbol = input[i].ToString();
                if (currentSymbol == "(")
                {
                    stack.Push(i);
                }
                else if (currentSymbol == ")")
                {
                    int startIndex = stack.Pop();
                    int length = i - startIndex + 1;
                    Console.WriteLine(input.Substring(startIndex, length));
                }
            }
        }
    }
}
