using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GroupSense
{
    public class WebScraper
    {
        const string BaseUrl = "http://books.toscrape.com/catalogue/";

        private async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        private List<string> ParseHtmlList(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var booksLinks = htmlDoc.DocumentNode.Descendants("article")
                    .Where(node => node
                        .GetAttributeValue("class", "")
                        .Contains("product_pod"))
                    .Select(node => node.ChildNodes
                        .Where(child => child.Name == "h3")
                        .First()
                        .Descendants("a")
                        .First()
                        .GetAttributeValue("href", ""))
                    .ToList();

            return booksLinks;

        }

        private Book ParseHtmlBook(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var book = new Book();
            book.Title = htmlDoc.DocumentNode.Descendants("h1").First().InnerText;

            book.Price = htmlDoc.DocumentNode.Descendants("p")
                .Where(node => node
                    .GetAttributeValue("class", "")
                    .Contains("price_color")).First().InnerText;

            book.Upc = htmlDoc.DocumentNode.Descendants("td").First().InnerText;

            book.Type = htmlDoc.DocumentNode.Descendants("td").Skip(1).First().InnerText;

            string availabilityText = htmlDoc.DocumentNode.Descendants("td").Skip(5).First().InnerText;
            if (availabilityText.StartsWith("In stock"))
            {
                availabilityText = availabilityText.Substring(availabilityText.IndexOf('(') + 1);
                availabilityText = availabilityText.Split(" ", StringSplitOptions.RemoveEmptyEntries).First();
                book.Availability = int.Parse(availabilityText);
            }
            else
            {
                book.Availability = 0;
            }

            book.Reviews = int.Parse(htmlDoc.DocumentNode.Descendants("td").Skip(6).First().InnerText);

            var descriptionTitle = htmlDoc.DocumentNode.Descendants("div")
                    .Where(node => node
                        .GetAttributeValue("id", "")
                        .Contains("product_description"))
                    .FirstOrDefault();

            if (descriptionTitle == null)
            {
                book.Description = "";
            }
            else
            {
                book.Description = descriptionTitle
                    .NextSibling
                    .NextSibling
                    .InnerText;
            }

            return book;
        }

        public List<Book> GetBooksForPage(int pageNumber)
        {
            string pageUrl = $"{BaseUrl}page-{pageNumber}.html";
            var response = CallUrl(pageUrl).Result;
            var bookList = ParseHtmlList(response);
            return bookList.Select(url => GetBook(url)).ToList();
        }

        public Book GetBook(string relativeUrl)
        {
            string bookUrl = $"{BaseUrl}{relativeUrl}";
            var response = CallUrl(bookUrl).Result;
            return ParseHtmlBook(response);

        }

        public List<Book> GetAllBooks(int maxPageNumber = 50)
        {
            int pageNumber = 1;
            var books = new List<Book>();

            while (pageNumber <= maxPageNumber)
            {
                books.AddRange(GetBooksForPage(pageNumber));
                pageNumber++;
            }

            return books;
        }
    }
}
