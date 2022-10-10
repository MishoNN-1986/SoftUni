using System;
using System.Collections.Generic;
using System.Text;

namespace _04._WorkForce.Models
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name)
            : base(name, 20)
        {
        }
    }
}
