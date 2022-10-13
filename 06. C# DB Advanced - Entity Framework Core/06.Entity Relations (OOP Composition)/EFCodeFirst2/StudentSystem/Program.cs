using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using StudentSystem.Data;
using System;
using System.Linq;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args) //Start Up Project
        {
            using (var context = new StudentDbContext())
            {
                context.Database
                    .EnsureCreated();

                SeedStudents(context);

                var student = context
                    .Students
                    .FirstOrDefault();

                var course = context
                    .Courses
                    .FirstOrDefault();

                student //many to many
                    .studentCourses
                    .Add(new StudentCourse()
                    {
                        Course = course
                    });

                context.SaveChanges();

                //context
                //    .Database
                //    .EnsureDeleted(); //трие базата
            }
        }

        private static void SeedStudents(StudentDbContext context)
        {
            if(context.Students.Count() == 0)
            {
                var studens = new Student[]
                {
                    new Student()
                    {
                        Name = new PersonName("Ivan", "Ivanov"),
                        Birthday = new DateTime(1989, 6, 24),
                        PhoneNumber = "123456789",
                        RegisteredOn = DateTime.Now
                    },
                    new Student()
                    {
                        Name = new PersonName("Petyr", "Ivanov"),
                        Birthday = new DateTime(1989, 5, 24),
                        PhoneNumber = "123456789",
                        RegisteredOn = DateTime.Now
                    },
                    new Student()
                    {
                        Name = new PersonName("Ivan", "Petrov"),
                        Birthday = new DateTime(1989, 8, 24),
                        PhoneNumber = "123456789",
                        RegisteredOn = DateTime.Now
                    }
                };

                context
                .Students
                .AddRange(studens);
                context.SaveChanges();
            }
        }
    }
}
