using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascII
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(word[0]);                 // взимаме символа намиращ се на 1-ва позиция
            Console.WriteLine(word[word.Length - 1]);   //за да вземем последната, без да знаем колко ще е дълга думата(дължината-1)
                                                        ///////////
            for (int i = 0; i < word.Length; i++)      // минаваме от 0-та до последната позиция на думата (i - показва на коя позиция се намира символа)
            {
                Console.WriteLine(word[i]);            // отпечатва последователно всяка буква от думата
            }
            //////////////////////
            char symbol = '%';       // слагаме char  винаги в единични кавички, зад всеки char стои число.
            Console.WriteLine((int)symbol);    // показва int стойността на %
            ///////////
            int number = 65;
            Console.WriteLine((char)number);      //показва char стойността на 65
                                                  //////

            Console.WriteLine('b' + 'e' + 't');      // събира и отпечатва int стойностите на буквите 
            Console.WriteLine("" + 'b' + 'e' + 't');   // събира празен string с char и се получава string+char+char и отпечатва string (bet)
                                                       ///////////////

            string words = Console.ReadLine();
            for (int i = words.Length - 1; i >= 0; i--)  // за да отпечатим думата на обратно, взимаме за i първоначално последния символ на думата до първия символ 0 
            {
                Console.WriteLine(words[i]);
            }
            ////////////////////
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];     //   на завъртането коя буква съответства(текущата буква)
                                                  // променлива, в която да си държим нашия символ(за да я декларираме трябва да и определим типа, името, и след това да и дадем стойност)
                int charInNumber = (int)currentLetter; //каква му е int стойността( може и без (int))
                sum += charInNumber;   //на всяко завъртане добавяме на всеки символ каква му е стойността към sum
                Console.WriteLine(sum);  // отпечатваме цялата стойност на всички символи от думата
            }
        }
    }
}
