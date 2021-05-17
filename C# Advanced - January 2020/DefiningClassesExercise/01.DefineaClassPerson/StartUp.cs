using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Pesho",
                Age = 20
            };
            Console.WriteLine($"{person.Name} => {person.Age}");
        }
    }
}

