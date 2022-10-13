using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperLection
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PersonCourse> Courses { get; set; }

        public int Age { get; set; }
    }
}
