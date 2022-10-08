using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> sumList = new Dictionary<string, int>();
            Dictionary<string, int> likesList = new Dictionary<string, int>();
            while (input != "Log out")
            {
                string[] commands = input.Split(": ");
                string operation = commands[0];
                string userName = commands[1];
                switch (operation)
                {
                    case "New follower":

                        if (!sumList.ContainsKey(userName))
                        {
                            sumList.Add(userName, 0);
                            likesList.Add(userName, 0);
                        }
                        break;
                    case "Like":
                        int count = int.Parse(commands[2]);
                        if (!sumList.ContainsKey(userName))
                        {
                            sumList.Add(userName, 0);
                            likesList.Add(userName, 0);
                        }
                        sumList[userName] += count;
                        likesList[userName] += count;
                        break;
                    case "Comment":
                        if (!sumList.ContainsKey(userName))
                        {
                            sumList.Add(userName, 0);
                            likesList.Add(userName, 0);
                        }
                        sumList[userName]++;
                        break;
                    case "Blocked":
                        if (sumList.ContainsKey(userName))
                        {
                            sumList.Remove(userName);
                            likesList.Remove(userName);
                        }

                        else
                        {
                            Console.WriteLine($"{userName} doesn't exist.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            likesList = likesList.OrderBy(l => l.Key).ToDictionary(a => a.Key, b => b.Value);
            likesList = likesList.OrderByDescending(l => l.Value).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"{sumList.Count} followers");
            foreach (var name in likesList)
            {
                Console.WriteLine($"{name.Key}: {sumList[name.Key]}");
            }
        }
    }
}

