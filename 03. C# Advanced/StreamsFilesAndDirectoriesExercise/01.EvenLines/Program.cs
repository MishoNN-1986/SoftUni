using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("./text.txt");
            char[] replace = { '-', ',', '.', '!', '?' };
            char replacement = '@';
            int count = 0;
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (count % 2 == 0)
                {
                    line = ReplaceAll(replace, replacement, line);
                    line = ReverseLine(line);
                    Console.WriteLine(line);
                }
                count++;
            }
        }
        static string ReplaceAll(char[] replace, char replacement, string line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (replace.Contains(symbol))
                {
                    sb.Append(replacement);
                }
                else
                {
                    sb.Append(symbol);
                }
            }
            return sb.ToString().TrimEnd(); // маха празните редове
        }

        static string ReverseLine(string line)
        {
            line = string.Join(" ", line.Split().Reverse()); //може и със stringbuilder и for
            return line;
        }
    }
}
