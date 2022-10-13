using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Data
{
    public class Student
    {
        public Student()
        {
            this.studentCourses = new List<StudentCourse>();
        }

        public int StudentId { get; set; }

        public PersonName Name { get; set; } //не е navigation property (няма id), то е owns type

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; } //not required

        public List<StudentCourse> studentCourses { get; set; }
    }
}
