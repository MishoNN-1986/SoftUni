using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<PeopleInfo> peopleInfo = new List<PeopleInfo>();
            while (command[0] != "End")
            {
                PeopleInfo people = new PeopleInfo(command[0], command[1], int.Parse(command[2]));
                peopleInfo.Add(people);
                command = Console.ReadLine().Split();
            }
            //peopleInfo.Sort((a, b) => string.Compare(a.Age.ToString(), b.Age.ToString()));
            peopleInfo = peopleInfo.OrderBy(a => a.Age).ToList();
            foreach (PeopleInfo people in peopleInfo)
            {
                Console.WriteLine($"{people.Name} with ID: {people.ID} is {people.Age} years old.");
            }
        }
    }
}
