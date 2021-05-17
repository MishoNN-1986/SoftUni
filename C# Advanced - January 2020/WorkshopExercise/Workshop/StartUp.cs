using System;

namespace Workshop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

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
