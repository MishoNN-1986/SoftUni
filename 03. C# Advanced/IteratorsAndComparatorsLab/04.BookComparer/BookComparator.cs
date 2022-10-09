using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {

        public int Compare(Book first, Book second)
        {
            var bookComparer = first.Title.CompareTo(second.Title);
            if (bookComparer == 0)
            {
                return second.Year.CompareTo(first.Year);
            }
            return bookComparer;
        }
    }
}
