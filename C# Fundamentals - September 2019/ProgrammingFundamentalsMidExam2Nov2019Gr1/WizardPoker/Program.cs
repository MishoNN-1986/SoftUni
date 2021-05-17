using System;
using System.Collections.Generic;
using System.Linq;
namespace WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Ready")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "Add":
                        string cardName = commandParams[1];
                        Add(input, cardName, newDeck);
                        break;
                    case "Insert":
                        int index = int.Parse(commandParams[2]);
                        string cardNameInsert = commandParams[1];
                        Insert(input, cardNameInsert, index, newDeck);
                        break;
                    case "Remove":
                        string removeCard = commandParams[1];
                        Remove(newDeck, removeCard);
                        break;
                    case "Swap":
                        string firstCard = commandParams[1];
                        string secondCard = commandParams[2];
                        Swap(newDeck, firstCard, secondCard);
                        break;
                    case "Shuffle":
                        Shuffle(newDeck);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }

        private static void Shuffle(List<string> newDeck)
        {
            newDeck.Reverse();
        }

        private static void Swap(List<string> newDeck, string firstCard, string secondCard)
        {
            int firstCardIndex = newDeck.IndexOf(newDeck.Single(i => i == firstCard));
            int secondCardIndex = newDeck.IndexOf(newDeck.Single(i => i == secondCard));
            if (firstCardIndex > secondCardIndex)
            {
                newDeck.Insert(firstCardIndex, secondCard);
                newDeck.Insert(secondCardIndex, firstCard);

                newDeck.RemoveAt(firstCardIndex + 2);
                newDeck.RemoveAt(secondCardIndex + 1);
            }
            else if (secondCardIndex > firstCardIndex)
            {
                newDeck.Insert(secondCardIndex, firstCard);
                newDeck.Insert(firstCardIndex, secondCard);

                newDeck.RemoveAt(secondCardIndex + 2);
                newDeck.RemoveAt(firstCardIndex + 1);

            }
        }

        private static void Remove(List<string> newDeck, string removeCard)
        {
            for (int i = 0; i < newDeck.Count; i++)
            {
                if (newDeck[i] == removeCard)
                {
                    newDeck.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Card not found.");
        }

        private static void Insert(List<string> input, string cardName, int index, List<string> newDeck)
        {
            if (index < 0 || index >= input.Count)
            {
                Console.WriteLine("Error!");
                return;
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == cardName)
                {
                    newDeck.Insert(index, cardName);
                    input.RemoveAt(i);
                    //input.RemoveAt(index + 1);
                    return;
                }
            }
            Console.WriteLine("Error!");
        }

        private static void Add(List<string> input, string cardName, List<string> newDeck)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == cardName)
                {
                    newDeck.Add(cardName);
                    input.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Card not found.");
        }
    }
}
