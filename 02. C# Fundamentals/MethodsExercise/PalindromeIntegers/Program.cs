using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber = int.Parse(Console.ReadLine());
            ReadIsThisNumberPalindrome(intNumber);
        }

        static void ReadIsThisNumberPalindrome(int numberInt)
        {
            string number = "" + numberInt;
            while (number != "END")
            {
                string palindrome = "true";
                int length = number.Length;
                for (int i = 0; i < length; i++)
                {
                    for (int j = length - 1 - i; j >= i; j--)
                    {
                        if (number[i] != number[j])
                        {
                            palindrome = "false";
                            break;
                        }
                        break;
                    }
                    if (palindrome == "false")
                    {
                        break;
                    }
                }
                Console.WriteLine(palindrome);
                number = Console.ReadLine();
            }
        }
    }
}
