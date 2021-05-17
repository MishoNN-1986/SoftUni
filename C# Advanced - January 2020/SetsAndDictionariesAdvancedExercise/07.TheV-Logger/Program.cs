using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>(); // може направо SortedSet
            while (input != "Statistics")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vloggerName = commands[0];
                string command = commands[1];
                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                    }
                    if (!vloggers[vloggerName].ContainsKey("followers"))
                    {
                        vloggers[vloggerName].Add("followers", new HashSet<string>());
                    }
                    if (!vloggers[vloggerName].ContainsKey("following"))
                    {
                        vloggers[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string followName = commands[2];
                    if (vloggerName != followName && vloggers.ContainsKey(vloggerName) &&
                        vloggers.ContainsKey(followName))
                    {
                        vloggers[followName]["followers"].Add(vloggerName);
                        vloggers[vloggerName]["following"].Add(followName);
                    }
                }
                input = Console.ReadLine();
            }
            StringBuilder printVloggers = new StringBuilder();
            vloggers = vloggers.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count).ToDictionary(v => v.Key, v => v.Value);
            printVloggers.Append($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.{Environment.NewLine}");
            int countVloggers = 0;
            foreach (var vlogger in vloggers.Keys)
            {
                countVloggers++;
                printVloggers.Append($"{countVloggers}. {vlogger} : {vloggers[vlogger]["followers"].Count} followers, {vloggers[vlogger]["following"].Count} following{Environment.NewLine}"); //{vlogger.Length} following{Environment.NewLine}
                if (countVloggers == 1 && vloggers[vlogger].Count > 0)
                {
                    foreach (var item in vloggers[vlogger]["followers"].OrderBy(n => n))
                    {
                        printVloggers.Append($"*  {item}{Environment.NewLine}");
                    }
                }
            }
            Console.WriteLine(printVloggers);
        }
    }
}
