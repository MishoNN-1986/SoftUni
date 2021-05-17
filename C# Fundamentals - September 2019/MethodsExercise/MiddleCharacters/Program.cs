using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetMiddleCharacters(text));
        }

        static string GetMiddleCharacters(string text)
        {
            int length = text.Length;
            string middleCharacter = string.Empty;
            if (length % 2 == 1)
            {
                middleCharacter = "" + text[(length / 2)];
            }
            else
            {
                middleCharacter = "" + text[(length / 2) - 1] + text[(length / 2)];
            }
            return middleCharacter;
        }
    }
}
