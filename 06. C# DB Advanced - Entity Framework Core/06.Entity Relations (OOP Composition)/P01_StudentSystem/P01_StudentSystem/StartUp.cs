using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_StudentSystem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //using (var db = new StudentSystemContext())
            //{
            //    db.Courses.Add(
            //        new Course
            //        {
            //            Name = "EF Core",
            //            Description = "description",
            //            Price = 100m
            //        });
            //    var affectedRows = db.SaveChanges();

            //    Console.WriteLine(affectedRows);
            //}

            using (var db = new StudentSystemContext())
            {
                var students_ = db.Students.ToList();
                var courses = db.Courses.ToList();

                var rnd = new Random();

                List<KeyValuePair<int, int>> randomIds = new List<KeyValuePair<int, int>>();

                HashSet<int> studentIds = new HashSet<int>();
                HashSet<int> courseIds = new HashSet<int>();

                for (int i = 0; i < 10000; i++)
                {
                    var randomStudentIndex = rnd.Next(0, students_.Count);
                    var randomStudent = students_[randomStudentIndex];

                    var randomCourseIndex = rnd.Next(0, courses.Count);
                    var randomCourse = courses[randomCourseIndex];

                    var studentInCourse = new StudentCourse
                    {
                        Student = randomStudent,
                        Course = randomCourse
                    };

                    //studentIds.Add(randomStudent.StudentId);
                    //courseIds.Add(randomCourse.CourseId);
                    

                    var randomKvp = new KeyValuePair<int, int>(
                        randomStudent.StudentId,
                        randomCourse.CourseId
                        );

                    randomIds.Add(randomKvp);
                    
                }

                randomIds = randomIds.Distinct().ToList();

                foreach (var idPair in randomIds)
                {
                    db.StudentCourses.Add(new StudentCourse
                    {
                        StudentId = idPair.Key,
                        CourseId = idPair.Value
                    });
                }

                var affectedRows = db.SaveChanges();

                Console.WriteLine(affectedRows);
            }

            using (var db = new StudentSystemContext())
            {
                List<Course> courses = db.Courses
                    .ToList();

                Random rnd = new Random();

                for (int i = 1; i < 15; i++)
                {
                    var randomIndex = rnd.Next(0, courses.Count);

                    var course = courses[randomIndex];

                    var resource = new Resource
                    {
                        Name = $"Lecture {i} from {course.Name}",
                        Url = $"www.softuni.bg/{course.Name}/Lecture{i}{course.Name}",
                        ResourceType = ResourceType.Video,
                        Course = course
                    };

                    db.Resoutces.Add(resource);
                }
                Console.WriteLine(db.SaveChanges());
            }

            string[] courseNames =
            {
                "Advances",
                "Fundamentals",
                "Databases",
                "Basics"
            };

            string[] languages =
            {
                "C#",
                "Java",
                "JS",
                "PHP",
                "GO"
            };
            var allCourses = GenerateCourses(courseNames, languages);

            //int numberOfSeededCourses = SeedStudents(allCourses);
            //Console.WriteLine(numberOfSeededCourses);

            string[] firstNames =
            {
                "Ivanа",
                "Petrana",
                "Gergana",
                "Annie",
                "Mimi"
            };

            string[] lastNames =
            {
                "Ivanova",
                "Georgieva",
                "Peshova",
                "Kirova"
            };

            var students = GenerateStudents(firstNames, lastNames);

            var addedStudents = SeedStudents(students);
            Console.WriteLine(addedStudents);
        }

        private static List<Student> GenerateStudents(string[] firstNames, string[] lastNames)
        {
            var students = new List<Student>();

            foreach (var firstName in firstNames)
            {
                foreach (var lastName in lastNames)
                {
                    var name = $"{firstName} {lastName}";

                    var student = new Student
                    {
                        Name = name
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        private static List<Course> GenerateCourses(string[] courses, string[] languages)
        {
            var initalPrice = 0;
            var allCourses = new List<Course>();

            foreach (var language in languages)
            {
                foreach (var module in courses)
                {
                    string coursName = $"{language} {module}";

                    var course = new Course
                    {
                        Name = coursName,
                        Description = $"Description for the {coursName}",
                        Price = initalPrice
                    };

                    allCourses.Add(course);

                    initalPrice += 25;
                }
            }
            return allCourses;
        }

        private static int SeedStudents(List<Student> students)
        {
            using (var context = new StudentSystemContext())
            {
                context.Students.AddRange(students);
                int seededCourses = context.SaveChanges();
                return seededCourses;
            }
        }
    }
}
