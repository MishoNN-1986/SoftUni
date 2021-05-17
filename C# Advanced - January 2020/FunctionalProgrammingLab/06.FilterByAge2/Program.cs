using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FilterByAge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < totalStudents; i++)
            {
                var curentStudentData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var student = new Student
                {
                    Name = curentStudentData[0],
                    Age = int.Parse(curentStudentData[1])
                };
                students.Add(student);
            }
            var filterText = Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());
            Func<Student, bool> filterFunc = student => true;
            // инициализираме го с true, за да са валидни всички студенти, ако filterText е различно от younger или older, иначе на Where долу ще даде грешка
            if (filterText == "younger")
            {
                filterFunc = s => s.Age < ageFilter; //като Select
            }
            else if (filterText == "older")
            {
                filterFunc = s => s.Age >= ageFilter;
            }
            var outputFormat = Console.ReadLine();
            //students = students.Where(filterFunc).ToList();
            Func<Student, string> outputFunc;
            if (outputFormat == "name age")
            {
                outputFunc = s => $"{s.Name} - {s.Age}";
            }
            else if (outputFormat == "age name")
            {
                outputFunc = s => $"{s.Age} - {s.Name}";
            }
            else if (outputFormat == "name")
            {
                outputFunc = s => $"{s.Name}";
            }
            else if (outputFormat == "age")
            {
                outputFunc = s => $"{s.Age}";
            }
            else
            {
                outputFunc = null; // иначе ще даде грешка на .Select()
            }
            students
                .Where(filterFunc)
                .Select(outputFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
