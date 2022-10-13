using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Data
{
    public class StudentCourse //many to many, в context се прави и композитен ключ, а в другите 2 класа се добавя колекцията
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }


        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
    }
}
