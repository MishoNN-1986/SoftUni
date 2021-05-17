using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> outputWords = new SortedDictionary<string, int>();
            string inputWords = File.ReadAllText(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\03.WordCount\word.txt");
            string[] words = inputWords.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            String pattern = @"[a-zA-Z']+"; // за да ми чете и последната дума трябва да има разстояние след нея в word.txt
            Regex regex = new Regex(pattern);

            using (var reader = new StreamReader(@"C:\SoftUni\C# Advanced-january 2020\StreamsFilesAndDirectories\03.WordCount\text.txt"))
            {
                string currentSentcence = reader.ReadLine();

                while (currentSentcence != null)
                {
                    foreach (Match match in regex.Matches(currentSentcence))
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (match.Value.ToLower() == words[i].ToLower() && !(outputWords.ContainsKey(words[i].ToLower())))
                            {
                                outputWords.Add(words[i].ToLower(), 1);
                            }
                            else if (match.Value.ToLower() == words[i].ToLower())
                            {
                                outputWords[words[i].ToLower()]++;
                            }
                        }
                    }
                    currentSentcence = reader.ReadLine();
                }
                foreach (var item in outputWords.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
