using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentAcadey
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 1; i <= num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                var list = students[name];
                list.Add(grade);
            }
            double count = 0;
            double averageGrade = 0;
            foreach (var student in students)
            {
                for (int i = 0; i < student.Value.Count; i++)
                {
                    count += student.Value[i];
                }
                averageGrade = count * 1.0 / student.Value.Count;
                student.Value.RemoveRange(0, student.Value.Count);
                student.Value.Add(averageGrade);
                averageGrade = 0;
                count = 0;
            }
            students = students.OrderByDescending(g => g.Value[0]).ToDictionary(g => g.Key, g => g.Value);
            foreach (var student in students)
            {
                if (student.Value[0] < 4.5)
                {
                    continue;
                }
                Console.WriteLine($"{student.Key} -> {student.Value[0]:F2}");
            }
        }
    }
}
