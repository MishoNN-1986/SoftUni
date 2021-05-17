using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> names = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < num; i++)
            {
                string[] namesAndGrades = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = namesAndGrades[0];
                decimal grade = decimal.Parse(namesAndGrades[1]);
                if (!names.ContainsKey(name))
                {
                    names.Add(name, new List<decimal>());
                }
                names[name].Add(grade);
            }
            StringBuilder output = new StringBuilder();
            decimal avg = 0;
            foreach (var name in names.Keys)  // foreach (var (name, grade) in names
            {                                 // Console.WriteLine($"{name} -> {string.Join(" ", grade)} (avg: {grade.Average():F2}))  

                if (names[name].Count != 0)
                {
                    avg = names[name].Average();
                }
                output.Append($"{name} -> ");
                foreach (var grade in names[name])
                {
                    output.Append($"{grade:F2} ");
                }
                //output.Append($"{string.Join(" ", names[name])}");
                output.Append($"(avg: {avg:F2}){Environment.NewLine}");
            }
            Console.WriteLine(output);
        }
    }
}
