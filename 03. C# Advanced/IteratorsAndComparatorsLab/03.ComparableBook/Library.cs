using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books); //или new List<Book>(books);
        }

        public SortedSet<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //може и тук да е this.books.Sort(); вместо SortedSet
            return new LibraryIterator(this.books); //!!!! 
        } //в тетрадката имам и как се прави по другия начин, както искат по условие, но е по дълъг

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;  // само се чете
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current
            {
                get
                {
                    return this.books[this.currentIndex]; // може и с => this.books[this.currentIndex];
                }
            }

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                this.currentIndex++;
                return this.currentIndex < this.books.Count; // => ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
