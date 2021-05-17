using System;
using System.Collections.Generic;
using System.Linq;
namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "end")
            {
                string courseName = command[0];
                string name = command[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                var list = courses[courseName];
                list.Add(name);
                command = Console.ReadLine().Split(" : ");
            }
            courses = courses.OrderByDescending(c => c.Value.Count).ToDictionary(c => c.Key, c => c.Value);
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                List<string> orderName = course.Value;
                orderName = orderName.OrderBy(o => o).ToList();
                foreach (var item in orderName)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
