using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Animals.Cats
{
    public class Tomcat : Cat
    {
        private const string DEFAULT_GENDER = "Male";

        public Tomcat(string name, int age)
            : base(name, age, DEFAULT_GENDER)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
