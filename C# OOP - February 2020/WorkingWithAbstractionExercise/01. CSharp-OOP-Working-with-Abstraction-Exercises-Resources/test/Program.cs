using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> op = new Queue<int>();
            op.Enqueue(4);
            op.Enqueue(7);
            op.Enqueue(1);
            op.Dequeue();
            op.Dequeue();
            op.Enqueue(5);
            op.Enqueue(7);
            Console.WriteLine(string.Join(" ", op));
        }
    }
}
