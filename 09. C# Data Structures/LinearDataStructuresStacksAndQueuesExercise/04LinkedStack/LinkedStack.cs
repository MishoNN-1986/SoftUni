using System;
using System.Collections.Generic;
using System.Text;

namespace _04LinkedStack
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T element = this.firstNode.value;
            this.firstNode = this.firstNode.NextNode;
            Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            Node<T> currentNode = this.firstNode;
            int index = 0;
            while (currentNode != null)
            {
                arr[index] = currentNode.value;
                currentNode = currentNode.NextNode;
                index++;
            }
            return arr;
        }

        private class Node<T>
        {
            public T value;
            public Node<T> NextNode { get; set; }
            public Node(T value, Node<T> nextNode = null)
            {
                this.value = value;
                this.NextNode = nextNode;
            }
        }

    }
}
