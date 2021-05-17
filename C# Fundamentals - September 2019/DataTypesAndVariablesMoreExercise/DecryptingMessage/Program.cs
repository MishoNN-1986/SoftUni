using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numbersLatinAlphabet = int.Parse(Console.ReadLine());
            string word = "";
            string letterToString = "";
            for (int i = 0; i < numbersLatinAlphabet; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter = (char)(key + letter);
                letterToString = "" + (letter.ToString());
                word += letterToString;
            }
            Console.WriteLine(word);
        }
    }
}
