using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Sign up")
            {
                string[] commands = command.Split(" ");
                string operation = commands[0];
                switch (operation)
                {
                    case "Case":
                        string typeLetters = commands[1];
                        userName = Case(userName, typeLetters);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        Reverse(userName, startIndex, endIndex);
                        break;
                    case "Cut":
                        string substring = commands[1];
                        userName = Cut(userName, substring);
                        break;
                    case "Replace":
                        string symbol = commands[1];
                        userName = Replace(userName, symbol);
                        break;
                    case "Check":
                        string validSymbol = commands[1];
                        Check(userName, validSymbol);
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static void Check(string userName, string validSymbol)
        {
            if (userName.Contains(validSymbol))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine($"Your username must contain {validSymbol}.");
            }
        }

        static string Replace(string userName, string symbol)
        {
            userName = userName.Replace(symbol, "*");
            Console.WriteLine(userName);
            return userName;
        }

        static string Cut(string userName, string substring)
        {
            if (!userName.Contains(substring))
            {
                Console.WriteLine($"The word {userName} doesn't contain {substring}.");
            }
            else
            {
                userName = userName.Remove(userName.IndexOf(substring), substring.Length);
                Console.WriteLine(userName);
            }
            return userName;
        }

        private static void Reverse(string userName, int startIndex, int endIndex)
        {
            if (startIndex >= 0 && endIndex > startIndex && endIndex < userName.Length)
            {
                string text = userName.Substring(startIndex, (endIndex - startIndex) + 1);
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Join("", charArray));
            }
            else
            {
                return;
            }
        }

        static string Case(string userName, string typeLetters)
        {
            if (typeLetters == "lower")
            {
                userName = userName.ToLower();
            }
            else
            {
                userName = userName.ToUpper();
            }
            Console.WriteLine(userName);
            return userName;
        }
    }
}
