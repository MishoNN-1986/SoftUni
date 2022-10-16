using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;

namespace GroupSense
{
    class Program
    {
        static void Main(string[] args)
        {
            var webScraper = new WebScraper();
            var books = webScraper.GetAllBooks();
            var csvParser = new CsvParser();
            var csv = csvParser.ParseBooks(books);
            System.IO.File.WriteAllText("report.csv", csv);
            Console.WriteLine("ok");
        }
    }
}
