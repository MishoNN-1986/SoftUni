using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Students
    {
        public Students(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:F2}"; // може и в кода да си го напиша
        }
    }
}
