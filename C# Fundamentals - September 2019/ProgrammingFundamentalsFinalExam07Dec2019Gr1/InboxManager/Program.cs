using System;
using System.Collections.Generic;
using System.Linq;

namespace InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> names = new Dictionary<string, List<string>>();
            while (input != "Statistics")
            {
                string[] splitInput = input.Split("->");
                string command = splitInput[0];
                string username = splitInput[1];
                if (command == "Add")
                {
                    if (names.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        names.Add(username, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string email = splitInput[2];
                    var list = names[username];
                    list.Add(email);
                }
                else if (command == "Delete")
                {
                    if (names.ContainsKey(username))
                    {
                        names[username].Clear();
                        names.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                input = Console.ReadLine();
            }
            names = names.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            names = names.OrderByDescending(e => e.Value.Count).ToDictionary(e => e.Key, e => e.Value);
            Console.WriteLine($"Users count: {names.Count}");
            foreach (var name in names)
            {
                Console.WriteLine(name.Key);
                for (int i = 0; i < name.Value.Count; i++)
                {
                    Console.WriteLine($" - {name.Value[i]}");
                }
            }
        }
    }
}
