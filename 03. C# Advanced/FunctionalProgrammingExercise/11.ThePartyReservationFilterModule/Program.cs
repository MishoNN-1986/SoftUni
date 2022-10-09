using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> filters = new List<string>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] commands = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string commandType = commands[0];
                string filterType = commands[1];
                string filterParameter = commands[2];
                if (commandType == "Add filter")
                {
                    filters.Add($"{filterType};{filterParameter}");
                }
                else if (commandType == "Remove filter")
                {
                    filters.Remove($"{filterType};{filterParameter}");
                }
                input = Console.ReadLine();
            }
            foreach (var currentFilter in filters)
            {
                string[] predicateArgs = currentFilter
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Predicate<string> predicate = GetPredicate(predicateArgs);
                names.RemoveAll(predicate);
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            Predicate<string> predicate = null;
            string predicateType = predicateArgs[0];
            string predicateArg = predicateArgs[1];
            if (predicateType == "Starts with")
            {
                predicate = new Predicate<string>((name) =>
               {
                   return name.StartsWith(predicateArg);
               });
            }
            else if (predicateType == "Ends with")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.EndsWith(predicateArg);
                  });
            }
            else if (predicateType == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(predicateArg);
                });
            }
            else if (predicateType == "Contains")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Contains(predicateArg);
                });
            }
            return predicate;
        }
    }
}
