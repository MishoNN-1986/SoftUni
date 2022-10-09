using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOperations = int.Parse(Console.ReadLine());

            Stack<string> text = new Stack<string>();
            Stack<int> commands = new Stack<int>();
            Stack<string> operations = new Stack<string>();

            for (int i = 0; i < numberOperations; i++)
            {
                string[] operation = Console.ReadLine().Split();
                string command = operation[0];
                switch (command)
                {
                    case "1":
                        string someString = operation[1].ToString();
                        AppendsSomeString(text, someString, commands, operations);
                        break;
                    case "2":
                        int count = int.Parse(operation[1]);
                        ErasesLastCountElements(text, count, commands, operations);
                        break;
                    case "3":
                        int index = int.Parse(operation[1]);
                        ReturnAtPositionIndex(text, index);
                        break;
                    case "4":
                        UndoesLastCommand(text, commands, operations);
                        break;
                }
            }
        }

        private static void UndoesLastCommand(Stack<string> text, Stack<int> commands, Stack<string> operations)
        {
            if (commands.Any())
            {
                int lastCommand = commands.Pop();
                string lastOperation = operations.Pop();
                if (lastCommand == 1)
                {
                    for (int i = 0; i < lastOperation.Length; i++)
                    {
                        text.Pop();
                    }
                }
                else if (lastCommand == 2)
                {
                    for (int i = lastOperation.Length - 1; i >= 0; i--)
                    {
                        string letter = lastOperation[i].ToString();
                        text.Push(letter);
                    }
                }
            }
        }

        private static void ReturnAtPositionIndex(Stack<string> text, int index)
        {
            if (text.Count >= index)
            {
                Stack<string> letters = new Stack<string>(text);
                for (int i = 0; i < index - 1; i++)
                {
                    letters.Pop();
                }
                Console.WriteLine(letters.Pop());
            }
        }

        private static void ErasesLastCountElements(Stack<string> text, int count, Stack<int> commands, Stack<string> operations)
        {
            if (text.Count >= count)
            {
                string getLetters = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    getLetters += "" + text.Pop();
                }
                commands.Push(2);
                operations.Push(getLetters);
            }
        }

        private static void AppendsSomeString(Stack<string> text, string someString, Stack<int> commands, Stack<string> operations)
        {
            for (int i = 0; i < someString.Length; i++)
            {
                string letter = someString[i].ToString();
                text.Push(letter);
            }
            commands.Push(1);
            operations.Push(someString);
        }
    }
}
