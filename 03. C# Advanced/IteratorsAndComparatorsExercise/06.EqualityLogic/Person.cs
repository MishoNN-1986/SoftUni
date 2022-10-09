using System;
using System.Collections.Generic;
using System.Text;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode(); // ако са равни не го записва(връщаме нещата, по които да сравняваме че са еднакви)
        }

        public override bool Equals(object obj) //равни са, но не са едни и същи
        {
            //var other = obj as Person;

            if (obj is Person person)
            {
                return this.Age == person.Age && this.Name == person.Name; //ако са равни няма да го добави в HashSet
            }
            return false;

        }
    }
}
