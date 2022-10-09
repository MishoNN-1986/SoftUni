using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> list;

        public Box(List<T> list)
        {
            this.List = list;
        }

        public List<T> List
        {
            get
            {
                return this.list;
            }
            set
            {
                this.list = value;
            }
        }

        public int CountBiggerStrings(List<T> list, T value)
        {
            int count = 0;
            foreach (var element in list)
            {
                if (value.CompareTo(element) < 0) // ако value е по-голямо връща 1, иначе -1, а ако е равно 0
                {
                    count++;
                }
            }
            return count;
        }
    }
}
