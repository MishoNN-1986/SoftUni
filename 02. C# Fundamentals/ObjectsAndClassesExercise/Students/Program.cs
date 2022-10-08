using System;
using System.Collections.Generic;
using System.Linq;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < count; i++)
            {
                string[] infoStudents = Console.ReadLine().Split();
                Students student = new Students(infoStudents[0], infoStudents[1], double.Parse(infoStudents[2]));
                students.Add(student);
            }
            students.Sort((a, b) => string.Compare(b.Grade.ToString(), a.Grade.ToString())); // ако не е с ToString(), не е за числа
            foreach (Students student in students)
            {
                Console.WriteLine(student); // $"{FirstName} {SecondName}: {Grade:F2}" тук и пак ще стане
            }
        }
    }
}
