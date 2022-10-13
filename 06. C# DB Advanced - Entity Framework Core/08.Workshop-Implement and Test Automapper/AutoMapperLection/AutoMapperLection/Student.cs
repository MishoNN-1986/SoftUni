using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperLection
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<StudentCourse> Courses { get; set; }

        public string FullName { get; set; }
    }
}
