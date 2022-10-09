using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.Books = books.ToList(); //или new List<Book>(books);
        }

        public List<Book> Books
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
            foreach (var book in this.Books)
            {
                yield return book;
            }
        } //в тетрадката имам и как се прави по другия начин, както искат по условие, но е по дълъг

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
