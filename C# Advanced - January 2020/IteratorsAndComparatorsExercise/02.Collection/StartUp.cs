using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;
            string commands = Console.ReadLine();
            while (commands != "END")
            {
                List<string> list = commands
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = list[0];
                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(list.Skip(1).ToArray());
                }
                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }
                else if (command == "PrintAll")
                {
                    listyIterator.PrintAll();
                    //foreach (var item in listyIterator)
                    //{
                    //    Console.Write(item + " ");
                    //}
                    //Console.WriteLine();
                }
                commands = Console.ReadLine();
            }
        }
    }
}
