using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(DeletesDuplicateLetters(text));
        }

        static string DeletesDuplicateLetters(string text)
        {
            StringBuilder output = new StringBuilder();
            output.Append(text[0]);
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    output.Append(text[i + 1]);
                }
            }
            return output.ToString();
        }
    }
}
