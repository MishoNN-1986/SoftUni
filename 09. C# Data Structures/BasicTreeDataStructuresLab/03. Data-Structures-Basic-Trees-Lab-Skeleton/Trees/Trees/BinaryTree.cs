using System;

public class BinaryTree<T>
{
    public T Value { get; set; }
    public BinaryTree<T> LeftChild { get; set; }
    public BinaryTree<T> RightChild { get; set; }

    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null) // нямаме колекция, защото знаем че наследниците са винаги 2
    {
        this.Value = value;
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public void PrintIndentedPreOrder(int indent = 0) // първо се принтира корена, после се обхожда ляво и дясно
    {
        Console.Write(new string(' ', indent * 2));
        Console.WriteLine(this.Value);

        if (this.LeftChild != null)
        {
            this.LeftChild.PrintIndentedPreOrder(indent + 1);
        }

        if (this.RightChild != null)
        {
            this.RightChild.PrintIndentedPreOrder(indent + 1);
        }
    }

    public void EachInOrder(Action<T> action) // ляво, корен, дясно - сортирани са
    {
        if (this.LeftChild != null)
        {
            this.LeftChild.EachInOrder(action);
        }

        action(this.Value);

        if (this.RightChild != null)
        {
            this.RightChild.EachInOrder(action);
        }
    }

    public void EachPostOrder(Action<T> action) // първо се обхожда ляво и дясно и след това се принтира
    {
        if (this.LeftChild != null)
        {
            this.LeftChild.EachPostOrder(action);
        }

        if (this.RightChild != null)
        {
            this.RightChild.EachPostOrder(action);
        }

        action(this.Value);
    }
}
