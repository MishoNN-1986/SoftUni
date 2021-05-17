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
            Person oldestMember = new Person(family.GetOldestMember().Name, family.GetOldestMember().Age);
            Console.WriteLine(oldestMember); //ако няма public override string ToString() в Person, трябва да е с .Name и .Age
        }
    }
}
