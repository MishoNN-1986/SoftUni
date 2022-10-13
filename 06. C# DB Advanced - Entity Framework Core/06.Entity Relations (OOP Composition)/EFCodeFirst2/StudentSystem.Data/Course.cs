using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Data
{
    public class Course
    {
        public Course()
        {
            this.Resources = new List<Resource>();
            this.studentCourses = new List<StudentCourse>();
        }

        [Key]
        public int CourseId { get; set; }

        [Column(TypeName = "NVARCHAR(80)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal Price { get; set; }

        public List<Resource> Resources { get; set; }

        public List<StudentCourse> studentCourses { get; set; }
    }
}
