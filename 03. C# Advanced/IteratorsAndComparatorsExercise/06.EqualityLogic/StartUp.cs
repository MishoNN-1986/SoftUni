using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SortedSet<Person> sortedSet = new SortedSet<Person>(); //без IComparable няма да може да добавя обекти
            HashSet<Person> hashSet = new HashSet<Person>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                sortedSet.Add(person);
                hashSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
