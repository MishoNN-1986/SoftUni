using _08._CollectionHierarchy.Core.Contracts;
using _08._CollectionHierarchy.IO.Contracts;
using _08._CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private Engine()
        {

        }

        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] inputElements = this.reader.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in inputElements)
            {
                this.writer.Write($"{addCollection.Add(item)} ");
            }

            this.writer.WriteLine();

            foreach (var item in inputElements)
            {
                this.writer.Write($"{addRemoveCollection.Add(item)} ");
            }

            this.writer.WriteLine();

            foreach (var item in inputElements)
            {
                this.writer.Write($"{myList.Add(item)} ");
            }

            this.writer.WriteLine();

            int count = int.Parse(this.reader.ReadLine());

            for (int i = 0; i < count; i++)
            {
                this.writer.Write($"{addRemoveCollection.Remove()} ");
            }

            this.writer.WriteLine();

            for (int i = 0; i < count; i++)
            {
                this.writer.Write($"{myList.Remove()} ");
            }

            this.writer.WriteLine();
        }
    }
}
