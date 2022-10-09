using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly List<Person> people; // за да не може някой да рови и да презаписва и да пренасочва към друг лист

        //public List<Person> People
        //{
        //    get { return this.people; }
        //    set { this.people = value; }
        //}
        public Family()
        {
            this.people = new List<Person>(); // за да можем да го ползваме като лист
        }
        public void AddMember(Person member)
        {
            //List<Person> people = new List<Person>();
            //people.Add(member);
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = this.people
                .OrderByDescending(p => p.Age)
                .FirstOrDefault(); // ако е null няма да изгори
            //int maxAge = 0;
            //string maxAgeName = "";
            //for (int i = 0; i < people.Count; i++)
            //{
            //    int age = people[i].Age;
            //    string name = people[i].Name;
            //    if (age > maxAge)
            //    {
            //        maxAge = age;
            //        maxAgeName = name;
            //    }
            //}
            //Person oldestMember = new Person(maxAgeName, maxAge);
            return oldestMember;
        }
    }
}
