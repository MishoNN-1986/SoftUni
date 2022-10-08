using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> names = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] commands = input.Split("-");
                string name = commands[0];
                if (commands[1] == "banned")
                {
                    if (names.ContainsKey(name))
                    {
                        names.Remove(name);
                    }
                }
                else
                {
                    string language = commands[1];
                    int points = int.Parse(commands[2]);
                    if (!names.ContainsKey(name))
                    {
                        names.Add(name, points);
                    }
                    else
                    {
                        if (points > names[name])
                        {
                            names[name] = points;
                        }
                    }
                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }
                    languages[language]++;
                }
                input = Console.ReadLine();
            }
            names = names.OrderByDescending(p => p.Value).ThenBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            Console.WriteLine("Results:");
            foreach (var item in names)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            languages = languages.OrderByDescending(q => q.Value).ThenBy(q => q.Key).ToDictionary(q => q.Key, q => q.Value);
            Console.WriteLine("Submissions:");
            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
