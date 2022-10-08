using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            Dictionary<string, int> list = new Dictionary<string, int>();
            Dictionary<string, int> receivedList = new Dictionary<string, int>();
            while (text != "Statistics")
            {
                string[] input = text.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string name = input[1];
                switch (command)
                {
                    case "Add":
                        int sentMessages = int.Parse(input[2]);
                        int receivedMessages = int.Parse(input[3]);
                        if (!list.ContainsKey(name))
                        {
                            list.Add(name, (sentMessages + receivedMessages));
                            receivedList.Add(name, receivedMessages);
                        }
                        break;
                    case "Message":
                        string sender = name;
                        string received = input[2];
                        if (list.ContainsKey(sender) && list.ContainsKey(received) && receivedList.ContainsKey(received))
                        {
                            list[sender]++;
                            list[received]++;
                            receivedList[received]++;
                            if (list[sender] >= capacity)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                receivedList.Remove(sender);
                                list.Remove(sender);
                            }
                            if (list[received] >= capacity)
                            {
                                Console.WriteLine($"{received} reached the capacity!");
                                list.Remove(received);
                                receivedList.Remove(received);
                            }
                        }
                        break;
                    case "Empty":
                        string people = input[1];
                        if (people == "All")
                        {
                            list.Clear();
                            receivedList.Clear();
                        }
                        else
                        {
                            if (list.ContainsKey(people))
                            {
                                list.Remove(people);

                            }
                            if (receivedList.ContainsKey(people))
                            {
                                receivedList.Remove(people);
                            }
                        }
                        break;
                }
                text = Console.ReadLine();
            }
            int userCount = list.Count;
            Console.WriteLine($"Users count: {userCount}");
            receivedList = receivedList.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            receivedList = receivedList.OrderByDescending(n => n.Value).ToDictionary(n => n.Key, n => n.Value);
            foreach (var name in receivedList)
            {
                Console.WriteLine($"{name.Key} - {list[name.Key]}");
            }
        }
    }
}
