using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] list = Console.ReadLine().Split();
            while (list[0]!="end")
            {
                string firstName = list[0];
                string lastName = list[1];
                int age = int.Parse(list[2]);
                string homeTown = list[3];
                Student student = new Student();  //може и с { и на следващите редове FirstName = firstName, LastName = lastName и т.н. 
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
                students.Add(student);
                list = Console.ReadLine().Split();
            }
            string theTown = Console.ReadLine();
            List<Student> filterTown = students.Where(x => x.HomeTown == theTown).ToList();
            foreach (Student town in filterTown)
            {
                Console.WriteLine($"{town.FirstName} {town.LastName} is {town.Age} years old.");
            }
        }
    }
}
