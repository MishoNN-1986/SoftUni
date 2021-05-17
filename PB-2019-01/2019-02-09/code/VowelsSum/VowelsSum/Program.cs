using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); // въвеждаме дума
            int sum = 0; //сумата на буквите
            for (int i = 0; i < word.Length; i++) // цикъл от 0 до дължината на текста
            {
                char letter = word[i]; //проверяваме всяка буква дали е гласна и добавяме към стойността й
                switch (letter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:break;

                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
