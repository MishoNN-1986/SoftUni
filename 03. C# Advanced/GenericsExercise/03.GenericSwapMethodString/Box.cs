using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
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

        public void Swap(int firstIndex, int secondIndex)
        {
            //if (firstIndex < 0 || firstIndex >= this.list.Count || secondIndex < 0 || secondIndex >= this.list.Count)
            //{
            //    throw new Exception("");
            //}

            T firstElement = list[firstIndex];
            T secondElement = list[secondIndex];
            list[firstIndex] = secondElement;
            list[secondIndex] = firstElement;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in this.list)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            return sb.ToString().Trim();
        }

    }
}
