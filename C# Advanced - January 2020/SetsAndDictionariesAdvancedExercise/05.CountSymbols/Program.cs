using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            //може и с SortedDictionary
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }
                symbols[symbol]++;
            }
            foreach (var symbol in symbols.Keys.OrderBy(s => s))
            {
                Console.WriteLine($"{symbol}: {symbols[symbol]} time/s");
            }
        }
    }
}
