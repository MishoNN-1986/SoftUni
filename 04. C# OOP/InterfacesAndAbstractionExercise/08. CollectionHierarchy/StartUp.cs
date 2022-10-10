using _08._CollectionHierarchy.Core;
using _08._CollectionHierarchy.Core.Contracts;
using _08._CollectionHierarchy.IO;
using _08._CollectionHierarchy.IO.Contracts;
using System;

namespace _08._CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
