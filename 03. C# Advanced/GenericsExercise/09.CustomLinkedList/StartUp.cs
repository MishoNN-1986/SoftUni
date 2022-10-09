using System;

namespace _09.CustomLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.AddFirst(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.AddLast(i);
            }

            doublyLinkedList
                .ForEach(n => Console.Write(n + " "));

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.RemoveFirst();
            }
            doublyLinkedList
                .ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        }
    }
}
