using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class MyStack
    {
        private int capacity; // за да можем да зануляваме
        private int[] data;

        public MyStack()
            : this(4)  //this.data = new int[4];
        {
        }

        public MyStack(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }

        public int Count { get; private set; }

        public void Push(int number)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = number;
            this.Count++;
        }

        public int Pop()
        {
            this.ValidateEmptyStack();
            var result = this.data[this.Count - 1];
            this.Count--;
            return result;
        }

        public int Peek()
        {
            this.ValidateEmptyStack();
            return this.data[this.Count - 1];
        }

        public void Clear()
        {
            this.data = new int[this.capacity];
            this.Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }

        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }

        private void ValidateEmptyStack()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty.");
            }
        }
    }
}
