using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
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
    }
}
