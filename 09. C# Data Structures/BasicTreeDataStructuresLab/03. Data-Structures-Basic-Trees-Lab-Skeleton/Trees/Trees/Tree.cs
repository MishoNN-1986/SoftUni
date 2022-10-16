using System;
using System.Collections.Generic;

public class Tree<T>
{
    public T Value { get; private set; }
    public List<Tree<T>> Children { get; private set; }

    public Tree(T value, params Tree<T>[] children) // вместо 1 по 1, без значение броя params ги прави на масив
    {
        this.Value = value;
        this.Children = new List<Tree<T>>(children);
    }

    public void Print(int indent = 0) // разстоянието отпред
    {
        Console.Write(new string(' ', indent * 2));
        Console.WriteLine(this.Value);

        foreach (var child in this.Children)
        {
            child.Print(indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);

        foreach (var child in this.Children)
        {
            child.Each(action);
        }
    }

    public IEnumerable<T> OrderDFS() // вместо с рекурсия, може и със стек
    {
        List<T> result = new List<T>();

        this.DFS(this, result);
        return result;
    }

    private void DFS(Tree<T> node, List<T> result)  //current node
    {
        foreach (Tree<T> child in node.Children)
        {
            this.DFS(child, result);
        }
        result.Add(node.Value);
    }

    public IEnumerable<T> OrderBFS()
    {
        Queue<Tree<T>> queue = new Queue<Tree<T>>();
        List<T> result = new List<T>();

        queue.Enqueue(this);
        while (queue.Count > 0)
        {
            Tree<T> current = queue.Dequeue();
            result.Add(current.Value);

            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }
        return result;
    }
}
