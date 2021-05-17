using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                string word = bannedWords[i];
                string asterisks = string.Empty;
                if (text.Contains(word))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        asterisks += "*";
                    }
                    text = text.Replace(word, asterisks); // може и text = text.Replace(word, new string('*', word.Lenght);
                }
            }
            Console.WriteLine(text);
        }
    }
}
