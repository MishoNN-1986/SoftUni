using System;
using System.Collections.Generic;

namespace Workshop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new MyList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Insert(2, 100);
            Console.WriteLine(list[2]);  //100
            Console.WriteLine(list[3]);  //30...

            var count = list.Count;
            Console.WriteLine(count);
            ////list.Clear();
            Console.WriteLine(list.Count);
            list[0] = 100;
            var number = list[1];
            Console.WriteLine(number);
            Console.WriteLine(list[2]);
            bool result = list["Pesho"];
            Console.WriteLine(result);
            //list[3] = 500; // out of range
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list[500]);
            var newList = new MyList();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            var removed = newList.RemoveAt(2);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
            Console.WriteLine(newList.Count);
            Console.WriteLine(removed);
            Console.WriteLine(newList.Contains(5));
            Console.WriteLine(newList.Contains(7));
            newList.Swap(1, 2);
            Console.WriteLine(newList[1]);

            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Count); //2

            var newResult = stack.Pop();
            Console.WriteLine(newResult); //20

            var newStack = new MyStack();
            for (int i = 0; i < 3; i++)
            {
                newStack.Push(i);
            }

            newStack.ForEach(n => Console.WriteLine(n * 10));

            var xList = new MyList();
            xList.Add(1);
            xList.Add(2);
            xList.Add(3);
            xList.Add(4);
            xList.Add(5);
            var secondRemoved = xList.RemoveAll(n => n % 2 == 0);
            Console.WriteLine(secondRemoved); //2
            Console.WriteLine(xList[0]); //1
            Console.WriteLine(xList[1]); //3
            Console.WriteLine(xList.Count); //3

        }
    }
}
