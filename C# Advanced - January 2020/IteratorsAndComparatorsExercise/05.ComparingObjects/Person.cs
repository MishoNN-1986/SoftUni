using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
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

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public int CompareTo(Person other)
        {
            var nameComparison = this.Name.CompareTo(other.Name);
            if (nameComparison == 0)
            {
                var ageComparison = this.Age.CompareTo(other.Age);
                if (ageComparison == 0)
                {
                    return this.Town.CompareTo(other.Town);
                }
                return ageComparison;
            }
            return nameComparison;
        }
    }
}
