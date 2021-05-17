using System;
using System.Collections.Generic;
using System.Text;

namespace _05LinkedQueue
{
    public class LinkedQueue<T>
    {

        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new QueueNode<T>(element);
            }
            else
            {
                var oldTail = this.tail;
                this.tail = new QueueNode<T>(element);
                this.tail.PrevNode = oldTail;
                oldTail.NextNode = this.tail;
            }
            this.Count++;
        }

        public T Dequeue()
        {
            T element;
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else if (this.Count == 1)
            {
                element = this.head.Value;
                this.head = this.tail = null;
            }
            else
            {
                element = this.head.Value;
                this.head = this.head.NextNode;
                this.head.PrevNode = null;
            }
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            var currentNode = this.head;
            int index = 0;
            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = this.head.NextNode;
            }
            return arr;
        }

        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T value)
            {
                this.Value = value;
            }
        }

    }
}
