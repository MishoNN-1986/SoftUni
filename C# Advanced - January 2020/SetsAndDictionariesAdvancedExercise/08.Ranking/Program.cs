using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsAndPasswords = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> namesAndPointsForContests = new Dictionary<string, Dictionary<string, int>>();
            string inputContestAndPassword = Console.ReadLine();
            while (inputContestAndPassword != "end of contests")
            {
                string[] contestAndPassword = inputContestAndPassword
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = contestAndPassword[0];
                string password = contestAndPassword[1];
                if (!contestsAndPasswords.ContainsKey(contest))
                {
                    contestsAndPasswords.Add(contest, password);
                }
                inputContestAndPassword = Console.ReadLine();
            }
            string inputResults = Console.ReadLine();
            while (inputResults != "end of submissions")
            {
                string[] results = inputResults.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = results[0];
                string password = results[1];
                string name = results[2];
                int points = int.Parse(results[3]);
                if (contestsAndPasswords.ContainsKey(contest) && contestsAndPasswords[contest] == password)
                {
                    if (!namesAndPointsForContests.ContainsKey(name))
                    {
                        namesAndPointsForContests.Add(name, new Dictionary<string, int>());
                    }
                    if (!namesAndPointsForContests[name].ContainsKey(contest))
                    {
                        namesAndPointsForContests[name].Add(contest, points);
                    }
                    else
                    {
                        if (points > namesAndPointsForContests[name][contest])
                        {
                            namesAndPointsForContests[name][contest] = points;
                        }
                    }
                }
                inputResults = Console.ReadLine();
            }
            namesAndPointsForContests = namesAndPointsForContests.OrderBy(n => n.Key).ToDictionary(n => n.Key, p => p.Value);
            int maxPoints = 0;
            string maxPointsName = string.Empty;
            foreach (var name in namesAndPointsForContests.Keys)
            {
                int points = 0;
                foreach (var contest in namesAndPointsForContests[name])
                {
                    points += contest.Value;
                }
                if (points > maxPoints)
                {
                    maxPoints = points;
                    maxPointsName = name;
                }
            }
            StringBuilder output = new StringBuilder();
            output.Append($"Best candidate is {maxPointsName} with total {maxPoints} points.{Environment.NewLine}");
            output.Append($"Ranking:{Environment.NewLine}");
            foreach (var name in namesAndPointsForContests.Keys)
            {
                output.Append($"{name}{Environment.NewLine}");
                foreach (var contest in namesAndPointsForContests[name].OrderByDescending(p => p.Value))
                {
                    output.Append($"#  {contest.Key} -> {contest.Value}{Environment.NewLine}");
                }
            }
            Console.WriteLine(output);
        }
    }
}
