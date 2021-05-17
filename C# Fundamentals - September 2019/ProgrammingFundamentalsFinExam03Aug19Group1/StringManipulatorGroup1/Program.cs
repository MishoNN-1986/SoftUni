using System;

namespace StringManipulatorGroup1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commands = command.Split(' ');
                string operation = commands[0];
                switch (operation)
                {
                    case "Translate":
                        char symbol = char.Parse(commands[1]);
                        char replacement = char.Parse(commands[2]);
                        text = ReplaceSymbolWithReplacementAndPrintResult(text, symbol, replacement);
                        break;
                    case "Includes":
                        string word = commands[1];
                        Includes(text, word);
                        break;
                    case "Start":
                        string startString = commands[1];
                        Start(text, startString);
                        break;
                    case "Lowercase":
                        text = Lowercase(text);
                        break;
                    case "FindIndex":
                        char index = char.Parse(commands[1]);
                        FindIndex(text, index);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(commands[1]);
                        int count = int.Parse(commands[2]);
                        text = Remove(text, startIndex, count);
                        break;
                }
                command = Console.ReadLine();
            }
        }

        static string Remove(string text, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= text.Length || count >= text.Length)
            {
                return text;
            }
            text = text.Remove(startIndex, count);
            Console.WriteLine(text);
            return text;
        }

        private static void FindIndex(string text, char index)
        {
            int position = text.LastIndexOf(index);
            Console.WriteLine(position);
        }

        static string Lowercase(string text)
        {
            text = text.ToLower();
            Console.WriteLine(text);
            return text;
        }

        private static void Start(string text, string startString)
        {
            string[] splitText = text.Split();
            bool isStartString = startString == splitText[0];
            Console.WriteLine(isStartString);
        }

        private static void Includes(string text, string word)
        {
            bool isIncludes = text.Contains(word);
            Console.WriteLine(isIncludes);
        }

        static string ReplaceSymbolWithReplacementAndPrintResult(string text, char symbol, char replacement)
        {
            text = text.Replace(symbol, replacement);
            Console.WriteLine(text);
            return text;
        }
    }
}
