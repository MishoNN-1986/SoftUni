using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(params T[] list)
        {
            this.list = new List<T>(list);
        }

        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return this.index < this.list.Count - 1; //true or false, дали има следващ елемент
        }

        public void Print()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.list[index]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", list));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in list)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
