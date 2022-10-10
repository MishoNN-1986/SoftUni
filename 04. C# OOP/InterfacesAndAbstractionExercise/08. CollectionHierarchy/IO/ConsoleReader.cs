using _08._CollectionHierarchy.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08._CollectionHierarchy.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
