using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Queue<char>(Console.ReadLine());
            var processed = new Stack<char>();

            var openBr = "([{";
            var closeBr = ")]}";

            bool isValid = true;
            while (input.Any() && isValid)
            {
                var br = input.Dequeue();

                if (openBr.Contains(br))
                {
                    processed.Push(br);
                }
                else
                {
                    char matchingBr = openBr[closeBr.IndexOf(br)];
                    processed.TryPop(out char lastBr);
                    isValid = lastBr == matchingBr;
                }
            }

            isValid = isValid && !processed.Any();

            Console.WriteLine(isValid ? "YES" : "NO");

            /*
            string input = Console.ReadLine();
            var stackSymbols = new Stack<string>();

            if (input.Length % 2 != 0 || input.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length && isValid; i++)
            {
                string symbol = input[i].ToString();
                if (symbol == "{" || symbol == "(" || symbol == "[")
                {
                    stackSymbols.Push(symbol);
                }
                else
                {
                    if (!stackSymbols.Any())
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                        
                    string stackSymbol = stackSymbols.Pop();
                    switch (symbol)
                    {
                        case "}":
                            if (stackSymbol != "{")
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ")":
                            if (stackSymbol != "(")
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case "]":
                            if (stackSymbol != "[")
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
            */
        }
    }
}
