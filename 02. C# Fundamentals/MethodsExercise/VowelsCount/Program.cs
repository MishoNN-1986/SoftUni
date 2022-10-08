using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(PrintSumOfVolels(word));
        }
        static int PrintSumOfVolels(string word)
        {
            int volelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (letter == 'a' || letter == 'o' || letter == 'u' || letter == 'e' || letter == 'i' || letter == 'A'
                    || letter == 'O' || letter == 'U' || letter == 'E' || letter == 'I')
                {
                    volelsCount++;
                }
            }
            return volelsCount;
        }
    }
}
