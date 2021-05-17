using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string input = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Contains(word))
                {
                    index = input.IndexOf(word);
                    input = input.Remove(index, word.Length);
                }
            }
            Console.WriteLine(input);
        }
    }
}
