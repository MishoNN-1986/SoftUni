using System;
using System.IO;
using System.Text;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("./Text.txt");
            int countLine = 0;
            StringBuilder output = new StringBuilder();
            foreach (var line in text)
            {
                int countLetters = 0;
                int countPunctuationMarks = 0;
                string[] currentLine = line.Split();
                foreach (var word in currentLine)
                {
                    foreach (var letter in word)
                    {
                        if (char.IsLetter(letter))
                        {
                            countLetters++;
                        }
                        else
                        {
                            countPunctuationMarks++;
                        }
                    }
                }
                output.Append($"Line {countLine + 1}: {text[countLine]} ({countLetters})({countPunctuationMarks}){Environment.NewLine}");
                countLine++;
            }
            File.WriteAllText("../../../Output.txt", output.ToString());
            Console.WriteLine(output);
        }
    }
}
