using StudentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class StudentData
    {
        public StudentData()
        {
            this.Students = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Students { get; private set; }

        public void Add(string name, int age, double grade)
        {
            if (!Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.Students[name] = student;
            }
        }

        public string GetDetails(string name)
        {
            if (this.Students.ContainsKey(name))
            {
                var student = this.Students[name];
                return student.ToString();
            }
            return null;
        }

    }
}

