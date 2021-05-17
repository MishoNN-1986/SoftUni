using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            List<Person> sortedPeople = family.GetSortedPeople();
            Console.WriteLine(string.Join(Environment.NewLine, sortedPeople));
            //for (int i = 0; i < family.GetSortedPeople().Count; i++)
            //{
            //    string name = family.GetSortedPeople()[i].Name;
            //    int age = family.GetSortedPeople()[i].Age;
            //    Person person = new Person(name, age);
            //    Console.WriteLine(person);
            //}
        }
    }
}
