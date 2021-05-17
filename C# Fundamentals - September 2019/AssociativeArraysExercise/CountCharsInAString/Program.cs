using System;
using System.Collections.Generic;
using System.Linq;
namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, int> countsAllCharacters = new Dictionary<char, int>();
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (countsAllCharacters.ContainsKey(word[i]))
                    {
                        countsAllCharacters[word[i]]++;
                    }
                    else
                    {
                        countsAllCharacters.Add(word[i], 1);
                    }
                }
            }
            foreach (var letter in countsAllCharacters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
