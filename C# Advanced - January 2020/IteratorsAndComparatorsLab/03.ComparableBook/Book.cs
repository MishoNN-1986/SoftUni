using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public IReadOnlyList<string> Authors { get; set; }// или да е private set

        public int CompareTo(Book other)
        {
            var bookComparison = this.Year.CompareTo(other.Year);
            if (bookComparison == 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            return bookComparison;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}".ToString();
        }
    }
}
