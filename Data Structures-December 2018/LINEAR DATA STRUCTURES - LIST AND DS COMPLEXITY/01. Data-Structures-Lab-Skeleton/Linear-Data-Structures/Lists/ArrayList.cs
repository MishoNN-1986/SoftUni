using System;

public class ArrayList<T>
{
    private const int Capacity = 2;

    private T[] data;

    public ArrayList()
    {
        this.data = new T[Capacity];
    }

    public int Count { get; private set; }

    public T this[int index] //достъп до елементите по индекс (метод)
    {
        get
        {
            IsIndexException(index);

            return this.data[index];
        }

        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.data[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count >= this.data.Length)
        {
            this.Resize();
        }
        this.data[this.Count++] = item; // първо ползваме count, и след това добавяме +1;
    }

    public T RemoveAt(int index)
    {
        IsIndexException(index);
        T item = this.data[index];
        for (int i = index; i < this.Count - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        this.Count--;

        if (this.Count <= this.data.Length / 4)
        {
            Shrink();
        }

        return item;
    }

    private void Shrink()
    {
        T[] newArray = new T[this.data.Length / 2];
        Array.Copy(this.data, newArray, this.Count);
        this.data = newArray;
    }

    private void IsIndexException(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    private void Resize()
    {
        T[] newArray = new T[this.data.Length * 2];
        Array.Copy(this.data, newArray, this.Count);
        this.data = newArray;
    }
}
