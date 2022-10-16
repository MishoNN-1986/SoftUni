using System;
using System.Collections.Generic;
using System.Text;

namespace GroupSense
{
    public class CsvParser
    {
        public string ParseBooks(List<Book> books)
        {
            StringBuilder result = new StringBuilder();

            foreach (var book in books)
            {
                // title, upc, type, price, availability, reviews, description 
                result.Append(ParseValue(book.Title))
                    .Append(",")
                    .Append(ParseValue(book.Upc))
                    .Append(",")
                    .Append(ParseValue(book.Type))
                    .Append(",")
                    .Append(ParseValue(book.Price))
                    .Append(",")
                    .Append(book.Availability)
                    .Append(",")
                    .Append(book.Reviews)
                    .Append(",")
                    .Append(ParseValue(book.Description))
                    .AppendLine();
            }
            return result.ToString();
        }

        private string ParseValue(string value)
        {
            return value.Replace(',', '^');
        }
    }
}
