using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string criteria = Console.ReadLine();
            while (criteria != "Party!")
            {
                string[] commands = criteria
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string commandType = commands[0];
                string[] predicateArgs = commands
                    .Skip(1)
                    .ToArray();

                Predicate<string> predicate = GetPredicate(predicateArgs);
                if (commandType == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (commandType == "Double")
                {
                    DoubleNames(names, predicate);
                }
                criteria = Console.ReadLine();
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
        }

        private static void DoubleNames(List<string> names, Predicate<string> predicate)
        {
            for (int i = 0; i < names.Count; i++)
            {
                string currName = names[i];
                if (predicate(currName))
                {
                    names.Insert(i, currName);
                    i++;
                }
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArgs) // може и без метод, а направо в предиката
        {
            // метода връща правилния предикат, в зависимост от това какво се иска в input-a
            Predicate<string> predicate = null;
            string predicateTyre = predicateArgs[0];
            string predicateArg = predicateArgs[1];
            if (predicateTyre == "StartsWith")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.StartsWith(predicateArg);
                  });
            }
            else if (predicateTyre == "EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(predicateArg);
                });
            }
            else if (predicateTyre == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(predicateArg);
                });
            }
            return predicate;
        }
    }
}
