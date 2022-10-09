using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CustomLinkedList
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> NextNode { get; set; }
        public ListNode<T> PreviousNode { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }

        public override string ToString() //правим го само заради дебъга
        {
            return this.Value.ToString();
        }
    }
}
