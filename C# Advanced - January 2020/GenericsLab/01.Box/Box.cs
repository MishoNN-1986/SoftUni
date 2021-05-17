using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(T element)
        {
            this.data.Push(element);
        }

        public T Remove()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Can not remove from empty collection");
            }
            T result = this.data.Pop();

            return result;

        }
    }
}
