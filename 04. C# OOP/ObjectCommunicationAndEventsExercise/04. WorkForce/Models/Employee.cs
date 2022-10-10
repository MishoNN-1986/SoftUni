using System;
using System.Collections.Generic;
using System.Text;

namespace _04._WorkForce.Models
{
    public abstract class Employee
    {
        protected Employee(string name, int hoursPerWeek)
        {
            this.Name = name;
            this.HoursPerWeek = hoursPerWeek;
        }

        public int HoursPerWeek { get; private set; }

        public string Name { get; private set; }
    }
}
