using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstNumber = ReadChar();
            char secondNumber = ReadChar();
            PrintCharactersBetweenTwoCharacters(firstNumber, secondNumber);
        }

        static void PrintCharactersBetweenTwoCharacters(char firstSimbol, char secondSimbol)
        {
            if (firstSimbol < secondSimbol)
            {
                for (int i = firstSimbol + 1; i < secondSimbol; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if (secondSimbol < firstSimbol)
            {
                for (int i = secondSimbol + 1; i < firstSimbol; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }

        static char ReadChar()
        {
            return char.Parse(Console.ReadLine());
        }
    }
}
