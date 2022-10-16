using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    private Node Head { get; set; }
    private Node Tail { get; set; }

    public int Count { get; private set; }

    public void AddFirst(T item)
    {
        Node oldHead = this.Head;
        this.Head = new Node(item);
        this.Head.Next = oldHead;
        if (this.Count == 0)
        {
            this.Tail = this.Head;
        }
        this.Count++;
    }

    public void AddLast(T item)
    {
        Node oldTail = this.Tail;
        this.Tail = new Node(item);

        if (this.Count == 0)
        {
            this.Head = this.Tail;
        }
        else
        {
            oldTail.Next = this.Tail;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        Node oldHead = this.Head;
        this.Head = this.Head.Next;
        Count--;
        if (this.Count == 0)
        {
            this.Tail = null;
        }
        return oldHead.Value;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        Node oldTail = this.Tail;

        if (this.Count == 1)
        {
            this.Head = this.Tail = null;
        }

        else
        {
            Node newTail = this.GetSecondToLast();
            newTail.Next = null;
            this.Tail = newTail;
        }
        this.Count--;

        return oldTail.Value;
    }

    private Node GetSecondToLast()
    {
        Node current = this.Head;
        while (current.Next != this.Tail)
        {
            current = current.Next;
        }
        return current;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}


