using System;
using System.Text;
namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverseWord = string.Empty;
            while (word != "end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }
                Console.WriteLine($"{word} = {reverseWord}");
                reverseWord = string.Empty;
                word = Console.ReadLine();
            }
        }
    }
}
