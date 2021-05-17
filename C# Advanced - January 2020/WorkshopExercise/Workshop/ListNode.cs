using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode(int value)
        {
            this.Value = value;
        }

        public override string ToString() //правим го само заради дебъга
        {
            return this.Value.ToString();
        }
    }
}
