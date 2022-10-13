using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            //this.Name = name;
            //this.PhoneNumber = phoneNumber;
            //this.RegisteredOn = DateTime.Now; //на ниво апликация, иначе в context .HasDefaultValueSql("GETDATE()") ниво база (резултата е един и същ)
            this.HomeworkSubmissions = new List<Homework>();
            this.CourseEnrollments = new List<StudentCourse>();
        }

        //[Key]
        public int StudentId { get; set; }

        //[Required]
        //[Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        //[RegularExpression("")] //regex
        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; private set; }

        public DateTime? BirthDay { get; set; }

        public ICollection<Homework> HomeworkSubmissions { get; set; }

        public ICollection<StudentCourse> CourseEnrollments { get; set; }
    }
}
