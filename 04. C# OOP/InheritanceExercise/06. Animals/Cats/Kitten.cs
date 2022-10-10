﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Animals.Cats
{
    public class Kitten : Cat
    {
        private const string DEFAULT_GENDER = "Female";

        public Kitten(string name, int age)
            : base(name, age, DEFAULT_GENDER)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
