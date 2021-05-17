using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = ReadLessons();

            var command = ReadCommand();

            while (command[0] != "course start")
            {
                string operation = command[0].ToString();
                string lessonTitle = command[1].ToString();

                switch (operation)
                {
                    case "Add":
                        Add(lessons, lessonTitle);
                        break;
                    case "Insert":
                        var index = int.Parse(command[2]);
                        Insert(lessons, lessonTitle, index);
                        break;
                    case "Remove":
                        Remove(lessons, lessonTitle);
                        break;
                    case "Swap":
                        var secondLessonTitle = command[2];
                        Swap(lessons, lessonTitle, secondLessonTitle);
                        break;
                    case "Exercise":
                        Exercise(lessons, lessonTitle);
                        break;
                }

                command = ReadCommand();
            }
            

            for (int i = 0; i < lessons.Count; i++)
            {
                var lesson = lessons[i];
                if (lesson != string.Empty)
                {
                    Console.WriteLine($"{i + 1}.{lesson}");
                }
            }

        }

        static List<string> ReadLessons()
        {
            List<string> lessons = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(lesson => lesson.Trim())
                .ToList();

            return lessons;
        }

        static List<string> ReadCommand()
        {
            return Console.ReadLine()
                .Split(new char[] { ':' }).ToList();
        }

        static string GetExercise(string lesson)
        {
            return lesson + "-Exercise";
        }

        static void Add(List<string> lessons, string lesson)
        {
            bool contains = lessons.Contains(lesson);
            if (contains)
            {
                return;
            }

            lessons.Add(lesson);
        }

        static void Insert(List<string> lessons, string lesson, int index)
        {
            bool contains = lessons.Contains(lesson);
            if (contains)
            {
                return;
            }

            if (index == lessons.Count)
            {
                lessons.Add(lesson);
            }
            else
            {
                lessons.Insert(index, lesson);
            }
        }

        static void Remove(List<string> lessons, string lesson)
        {
            lessons.Remove(lesson);

            string exercise = GetExercise(lesson);
            lessons.Remove(GetExercise(lesson));
        }

        static void Swap(List<string> lessons, string firstLesson, string secondLesson)
        {
            bool containsFirstLesson = lessons.Contains(firstLesson);
            bool containsSecondLesson = lessons.Contains(secondLesson);
            if (!containsFirstLesson || !containsSecondLesson)
            {
                return;
            }

            string firstLessonExercise = GetExercise(firstLesson);
            string secondLessonExercise = GetExercise(secondLesson);

            int firstLessonIndex = lessons.FindIndex(x => x == firstLesson);
            int secondLessonIndex = lessons.FindIndex(x => x == secondLesson);

            bool hasFirstLessonExercise = HasExercise(lessons, firstLesson);
            bool hasSecondLessonExercise = HasExercise(lessons, secondLesson);

            lessons[firstLessonIndex] = secondLesson;
            lessons[secondLessonIndex] = firstLesson;

            if (hasFirstLessonExercise && hasSecondLessonExercise)
            {
                lessons[firstLessonIndex + 1] = secondLessonExercise;
                lessons[secondLessonIndex + 1] = firstLessonExercise;
            }
            else if (!hasFirstLessonExercise && hasSecondLessonExercise)
            {
                lessons[secondLessonIndex + 1] = string.Empty;
                Insert(lessons, secondLessonExercise, firstLessonIndex + 1);
            }
            else if (hasFirstLessonExercise && !hasSecondLessonExercise)
            {
                lessons[firstLessonIndex + 1] = string.Empty;
                lessons.Insert(secondLessonIndex + 1, firstLessonExercise);
            }
        }

        static bool HasExercise(List<string> lessons, string lesson)
        {
            int lessonIndex = lessons.FindIndex(x => x == lesson);
            string lessonExercise = GetExercise(lesson);
 
            bool haslessonExercise = lessonIndex + 1 < lessons.Count && lessons[lessonIndex + 1] == lessonExercise;
            return haslessonExercise;
        }

        static void Exercise(List<string> lessons, string lesson)
        {
            bool containsLesson = lessons.Contains(lesson);
            string lessonExercise = GetExercise(lesson);
            int lessonIndex = lessons.FindIndex(x => x == lesson);
            bool haslessonExercise = HasExercise(lessons, lesson);

            if (haslessonExercise)
            {
                return;
            }

            if (containsLesson)
            {
                Insert(lessons, lessonExercise, lessonIndex + 1);
            }
            else
            {
                lessons.Add(lesson);
                lessons.Add(lessonExercise);
            }
        }
    }
}
