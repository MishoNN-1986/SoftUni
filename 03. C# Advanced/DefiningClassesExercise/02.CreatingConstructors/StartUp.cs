using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person() // има 3 overloads
            {

            };
            Console.WriteLine($"{person.Name} => {person.Age}");
            //Person torilka = new Person("Pesho", 18);
            //Console.WriteLine($"{torilka.Name} => {torilka.Age}");
        }
    }
}
