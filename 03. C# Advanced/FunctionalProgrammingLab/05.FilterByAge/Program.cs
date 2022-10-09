using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<Dictionary<string, int>, string, int, Dictionary<string, int>> FuncFilterByAge = FilterByAge;

            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, int> namesAndAges = new Dictionary<string, int>();
            for (int i = 0; i < lines; i++)
            {
                var nameAndAge = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);
                if (!namesAndAges.ContainsKey(name))
                {
                    namesAndAges.Add(name, age);
                }
            }
            string conditionOutput = Console.ReadLine();
            int ageOutput = int.Parse(Console.ReadLine());
            var format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //FilterByAge(namesAndAges, conditionOutput, ageOutput);
            PrintFormattedOutput(FilterByAge(namesAndAges, conditionOutput, ageOutput), format);
        }

        static Dictionary<string, int> FilterByAge(Dictionary<string, int> namesAndAges,
            string conditionOutput, int ageOutput)
        {
            Dictionary<string, int> namesFilterByAges = new Dictionary<string, int>();
            foreach (var (name, age) in namesAndAges)
            {
                if (conditionOutput == "older")
                {
                    if (age >= ageOutput)
                    {
                        namesFilterByAges.Add(name, age);
                        //Console.WriteLine(name);
                    }
                }
                else if (conditionOutput == "younger")
                {
                    if (age < ageOutput)
                    {
                        namesFilterByAges.Add(name, age);
                    }
                }
            }
            return namesFilterByAges;
        }
        static void PrintFormattedOutput(Dictionary<string, int> FilterByAge, string[] format)
        {
            if (format.Length == 1 && format[0] == "name")
            {
                foreach (var name in FilterByAge)
                {
                    Console.WriteLine(name.Key);
                }
            }
            else if (format.Length == 1 && format[0] == "age")
            {
                foreach (var age in FilterByAge)
                {
                    Console.WriteLine(age.Value);
                }
            }
            else if (format.Length == 2 && format[0] == "name")
            {
                foreach (var (name, age) in FilterByAge)
                {
                    Console.WriteLine($"{name} - {age}");
                }
            }
            else if (format.Length == 2 && format[0] == "age")
            {
                foreach (var (name, age) in FilterByAge)
                {
                    Console.WriteLine($"{age} - {name}");
                }
            }
        }
    }
}
