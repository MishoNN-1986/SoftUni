﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {this.value}";
        }

    }
}
