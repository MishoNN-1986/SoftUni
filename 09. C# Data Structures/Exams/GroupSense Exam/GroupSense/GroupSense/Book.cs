using System;
using System.Collections.Generic;
using System.Text;

namespace GroupSense
{
    public class Book
    {
        public string Title { get; set; }
        public string Upc { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public int Availability { get; set; }
        public int Reviews { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Title}, {Upc}, {Type}, {Price}, {Availability}, {Reviews}, {Description.Substring(0, 5)}";
        }
    }
}
