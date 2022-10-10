using _08._CollectionHierarchy.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08._CollectionHierarchy.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
