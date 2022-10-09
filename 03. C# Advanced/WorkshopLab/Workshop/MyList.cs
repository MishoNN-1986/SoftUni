using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    public class MyList //<T> (generic pyte!) след името на класа, и след това на всякъде където е грешка и int се слага Т, а ако е сравнение equals, за да може листа в базовия клас да се пише<string, int.....>
    { // след името на класа : IEnumerable<T>, за да може да се foreach, ctr+., и най-долу се появяват и ги променяме
        //List е generic
        private int capacity;
        private int[] data;

        // пише се .this,  за да се види че определена променлива идва от класа, а не от метода

        public MyList() // преизползва долния с капацитет 4
            : this(4)
        {

        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }

        public int Count { get; private set; } // няма логика някой да добавя count

        public void Add(int number)
        {
            this.CheckIfResizeNeeded();
            this.data[this.Count] = number;
            this.Count++;
        }

        public int RemoveAll(Func<int, bool> filter)
        {
            var removed = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (filter(this.data[i]))
                {
                    this.RemoveAt(i);
                    removed++;
                }
            }
            return removed;
        }// връща колко елента сме изтрили

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[this.capacity];
        }

        public void Insert(int index, int element)
        {
            this.ValidateIndex(index);
            this.CheckIfResizeNeeded();
            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }
            this.data[index] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);
            var result = data[index];
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }
            this.Count--;
            return result;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++) // до count, за да не въртим нулите
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstIndexElement = this.data[firstIndex];
            var secondIndexElement = this.data[secondIndex];
            this.data[firstIndex] = secondIndexElement;
            this.data[secondIndex] = firstIndexElement;
        }

        public int this[int index]  // индексатор, може да приема всичко и да връща всичко
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }

        public bool this[string text]
        {
            get
            {
                return text == "Pesho";
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return;
            }
            var message = this.Count == 0
                ? "The list is empty"
                : $"The list has {this.Count} elements and it is zero-based.";

            throw new Exception($"Index out of range. {message} ");

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

        private void CheckIfResizeNeeded()
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
        }

        //public IEnumerator<T> GetEnumerator()  //тук винаги пишем логиката
        //{
        //    => this.data.Take(this.Count).ToList().GetEnumerator();  //return
        //}

        //IEnumerator IEnumerable.GetEnumerator()  // не е public, не може да се достъпва от вън
        //{
        //    => this.GetEnumerator(); //return винаги горния
        //}
    }
}
