using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(); //sortedset?
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                int age = int.Parse(info[1]);
                string town = info[2];
                Person person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine();
            }
            int personComparePosition = int.Parse(Console.ReadLine()) - 1;
            if (personComparePosition >= 0 && personComparePosition < people.Count)
            {
                int countOfMatches = 1;
                for (int i = 0; i < people.Count; i++)
                {
                    if (i == personComparePosition) // можем да извадим 1, или целия person
                    {
                        continue;
                    }
                    Person person = people[i];
                    if (person.CompareTo(people[personComparePosition]) == 0)
                    {
                        countOfMatches++;
                    }
                }
                if (countOfMatches == 1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    int totalNumberOfPeople = people.Count;
                    int numberOfNotEqualPeople = totalNumberOfPeople - countOfMatches;
                    Console.WriteLine($"{countOfMatches} {numberOfNotEqualPeople} {totalNumberOfPeople}");
                }
            }
        }
    }
}
