using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Student2> students = new List<Student2>();
            string[] list = Console.ReadLine().Split();
            while (list[0] != "end")
            {
                string firstName = list[0];
                string lastName = list[1];
                int age = int.Parse(list[2]);
                string homeTown = list[3];
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student2 student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                    //students.Add(student);
                }
                else
                {
                    Student2 student = new Student2();  //може и с { и на следващите редове FirstName = firstName, LastName = lastName и т.н. 
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                    students.Add(student);
                }
                list = Console.ReadLine().Split();
            }
            string theTown = Console.ReadLine();
            List<Student2> filterTown = students.Where(x => x.HomeTown == theTown).ToList();
            foreach (Student2 town in filterTown)
            {
                Console.WriteLine($"{town.FirstName} {town.LastName} is {town.Age} years old.");
            }
        }

        static bool IsStudentExisting(List<Student2> students, string firstName, string lastName)
        {
            foreach (Student2 student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student2 GetStudent(List<Student2> students, string firstName, string lastName)
        {
            Student2 existingStudent = null;
            foreach (Student2 student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
