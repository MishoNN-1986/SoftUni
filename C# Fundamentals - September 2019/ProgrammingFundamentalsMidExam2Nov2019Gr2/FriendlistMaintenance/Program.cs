using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendlistMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allFriends = Console.ReadLine().Split(", ").ToList();
            int lostCount = 0;
            int blackCount = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] splitCommand = command.Split();
                switch (splitCommand[0])
                {
                    case "Blacklist":
                        string name = splitCommand[1];
                        BlackList(allFriends, name);
                        break;
                    case "Error":
                        int index = int.Parse(splitCommand[1]);
                        Error(allFriends, index);
                        break;
                    case "Change":
                        int changeIndex = int.Parse(splitCommand[1]);
                        string changeName = splitCommand[2];
                        Change(allFriends, changeIndex, changeName);
                        break;
                }

            }
            foreach (var item in allFriends)
            {
                if (item == "Blacklisted")
                {
                    blackCount++;
                }
                else if (item == "Lost")
                {
                    lostCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blackCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", allFriends));
        }

        private static void Change(List<string> allFriends, int changeIndex, string changeName)
        {
            if (changeIndex < 0 || changeIndex >= allFriends.Count)
            {
                return;
            }
            Console.WriteLine($"{allFriends[changeIndex]} changed his username to {changeName}.");
            allFriends[changeIndex] = changeName;
        }

        private static void CopyAllFriends(List<string> allFriends, List<string> copyAllFriends)
        {
            foreach (var item in allFriends)
            {
                copyAllFriends.Add(item);
            }
        }

        private static void Error(List<string> allFriends, int index)
        {
            if (index < 0 || index >= allFriends.Count)
            {
                return;
            }
            string name = allFriends[index];
            if (name == "Blacklisted" || name == "Lost")
            {
                return;
            }
            allFriends[index] = "Lost";
            Console.WriteLine($"{name} was lost due to an error.");
        }

        private static void BlackList(List<string> allFriends, string name)
        {
            for (int i = 0; i < allFriends.Count; i++)
            {
                if (allFriends[i] == name)
                {
                    allFriends[i] = "Blacklisted";

                    Console.WriteLine($"{name} was blacklisted.");
                    return;
                }
            }
            Console.WriteLine($"{name} was not found.");
        }
    }
}
