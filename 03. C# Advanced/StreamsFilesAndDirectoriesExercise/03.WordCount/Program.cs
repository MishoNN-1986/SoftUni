using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadLines("../../../words.txt");
            var text = File.ReadAllText("../../../text.txt");
            string pattern = @"[A-Z]*[a-z]*";
            MatchCollection wordsInText = Regex.Matches(text, pattern);
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                int count = 0;
                foreach (Match item in wordsInText)
                {
                    if (word.ToLower() == item.Value.ToLower())
                    {
                        count++;
                    }
                }
                if (!countWords.ContainsKey(word))
                {
                    countWords.Add(word, 0);
                }
                countWords[word] += count;
            }
            StringBuilder output = new StringBuilder();
            foreach (var word in countWords)
            {
                output.AppendLine($"{word.Key} - {word.Value}");
            }
            File.WriteAllText("../../../actualResult.txt", output.ToString().TrimEnd());
            Console.WriteLine($"actualResult: {Environment.NewLine}{output.ToString().TrimEnd()}");
            countWords = countWords.OrderByDescending(c => c.Value).ToDictionary(w => w.Key, c => c.Value);
            output.Clear();
            foreach (var word in countWords)
            {
                output.AppendLine($"{word.Key} - {word.Value}");
            }
            File.WriteAllText("../../../expectedResult.txt", output.ToString().TrimEnd());
            Console.WriteLine($"expectedResult: {Environment.NewLine}{output.ToString().TrimEnd()}");
        }
    }
}
