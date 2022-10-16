using System;

namespace _03ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new ArrayStack<int>();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            stack.Pop();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(String.Join(" ", stack.ToArray()));
        }
    }
}
