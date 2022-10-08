using System;

namespace Grades
{
      class Program
    {
        static void Main(string[] args)
        {
            TypeGrade(double.Parse(Console.ReadLine()));
        }
        private static void TypeGrade(double inputGrade)
        {
            string grade = string.Empty;
            if (inputGrade >= 2 && inputGrade <= 2.99)
            {
                grade = "Fail";
            }
            else if (inputGrade >= 3 && inputGrade <= 3.49)
            {
                grade = "Poor";
            }
            else if (inputGrade >= 3.5 && inputGrade <= 4.49)
            {
                grade = "Good";
            }
            else if (inputGrade >= 4.5 && inputGrade <= 5.49)
            {
                grade = "Very good";
            }
            else if (inputGrade >= 5.5 && inputGrade <= 6)
            {
                grade = "Excelent";
            }
            Console.WriteLine(grade);
        }
    }
}
