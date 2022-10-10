using System;
using System.Collections.Generic;
using System.Text;

namespace _04._WorkForce.Models
{
    public class StandardEmployee : Employee
    {
        public StandardEmployee(string name)
            : base(name, 40)
        {
        }
    }
}
