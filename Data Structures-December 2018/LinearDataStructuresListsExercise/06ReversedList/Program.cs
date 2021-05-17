using System;

namespace _06ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ReversedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list[3]);
            list.RemoveAt(3);
            Console.WriteLine(list[3]);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
