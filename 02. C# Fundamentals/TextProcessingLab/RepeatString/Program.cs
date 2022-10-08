using System;
using System.Text;
namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
