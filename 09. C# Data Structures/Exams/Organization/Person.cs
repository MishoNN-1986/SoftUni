using System;
using System.Collections.Generic;
using System.Text;

namespace Organization
{
    public class Person
    {
        public Person(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
