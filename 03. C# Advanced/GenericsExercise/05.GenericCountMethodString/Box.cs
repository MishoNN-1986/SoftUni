using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable // подсигуряваме си, че валютата които имаме ще могат да бъдат сравнявани, чрез IComparable метода
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
