using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03ArrayStack
{
    public class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T element = this.elements[this.Count - 1];
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            Array.Copy(this.elements.Reverse().Skip(this.elements.Length - this.Count).ToArray(), arr, this.Count);
            return arr;
        }

        private void Grow()
        {
            T[] newArray = new T[this.Count * 2];
            Array.Copy(this.elements, newArray, this.Count);
            this.elements = newArray;
        }

    }
}
