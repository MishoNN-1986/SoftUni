namespace BookShop
{
    using Data;
    using Initializer;
    using System;
    using System.Globalization;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using System.Text;
    using BookShop.Models.Enums;
    using Z.EntityFramework.Plus;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db); //за създаване и пълнене на базата (lazy loading), колекцията и navigation properties да са virtual


                //[1] -------------------------------------------------

                //string command = Console.ReadLine();

                //var result = GetBooksByAgeRestriction(db, command);

                //Console.WriteLine(result); 

                //[2]-------------------------------------------------

                //var result = GetGoldenBooks(db);

                //Console.WriteLine(result);

                //[3]----------------------------------------------------

                //var result = GetBooksByPrice(db);

                //Console.WriteLine(result);

                //[4]----------------------------------------------------------

                //int year = int.Parse(Console.ReadLine());

                //var result = GetBooksNotReleasedIn(db, year);

                //Console.WriteLine(result);

                //[5]-----------------------------------------------------------------

                //string categories = Console.ReadLine();

                //var result = GetBooksByCategory(db, categories);

                //Console.WriteLine(result);

                //[6]-----------------------------------------------------------------------

                //string date = Console.ReadLine();

                //var result = GetBooksReleasedBefore(db, date);

                //Console.WriteLine(result);

                //[7]----------------------------------------------------------------------

                //string endingString = Console.ReadLine();

                //var result = GetAuthorNamesEndingIn(db, endingString);

                //Console.WriteLine(result);

                //[8]--------------------------------------------------------------------------

                //string containingString = Console.ReadLine();

                //var result = GetBookTitlesContaining(db, containingString);

                //Console.WriteLine(result);

                //[9]-----------------------------------------------------------------------------

                //string startString = Console.ReadLine();

                //var result = GetBooksByAuthor(db, startString);

                //Console.WriteLine(result);

                //[10]----------------------------------------------------------------------

                //int num = int.Parse(Console.ReadLine());

                //var result = CountBooks(db, num);

                //Console.WriteLine(result);

                //[11]----------------------------------------------------------------------------

                //var result = CountCopiesByAuthor(db);

                //Console.WriteLine(result);

                //[12]-------------------------------------------------------------------------

                //var result = GetTotalProfitByCategory(db);

                //Console.WriteLine(result);

                //[13]----------------------------------------------------------------------------

                //var result = GetMostRecentBooks(db);
                //Console.WriteLine(result);

                //[14]-----------------------------------------------------------------------------------
                // Z.EntityFramework.Plus.EFCore

                //IncreasePrices(db);

                //[15]-----------------------------------------------------------------------------

                //int result = RemoveBooks(db);

                //Console.WriteLine(result);

                //[BonusTask]

                GetAuthorWithHisBooksAndCategories(db);

            }
        }

        private static void GetAuthorWithHisBooksAndCategories(BookShopContext context)
        {

            //var booksSelect = context.Books.Select(x => x.BookCategories);  //имаме достъп до колекцията
            var booksSelectMany = context.Books
                .SelectMany(x => x.BookCategories) //имаме достъп до колекцията и нейните стойности
                                                   //.Include(x => x.Book) // вместо него може 3 вътрешни select-a, или колекцията и навигиращите пропартита да са virtual + .UseLazyLoadingProxies() на DBContext
                .ToList();

            //foreach (var bookCategories in booksSelect)
            //{
            //    Console.WriteLine(bookCategories);
            //}

            foreach (var bookCategory in booksSelectMany)
            {
                Console.WriteLine(bookCategory.Book.Title);
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(a => a.AgeRestriction == ageRestriction) //Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(t => t.Title)
                .OrderBy(x => x)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(e => e.EditionType == Enum.Parse<EditionType>("Gold")) //EditionType.ToString() == "Gold"
                .Where(c => c.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(t => t.Title)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(p => p.Price > 40)
                .Select(b => new
                {
                    bookTitle = b.Title,
                    bookPrice = b.Price
                }).ToList()
                .OrderByDescending(b => b.bookPrice)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(b => $"{b.bookTitle} - ${b.bookPrice:F2}"));

            return result;
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var books = context.Books
                .Where(bk => bk.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower())))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime targetDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture); //DateTime.Parse(date);

            var books = context.Books
                .Where(b => b.ReleaseDate.Value < targetDate) // value, защото ако е null ще гръмне
                .OrderByDescending(b => b.ReleaseDate.Value)
                .Select(x => new
                {
                    x.Title,
                    x.EditionType,
                    x.Price
                })
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:F2}"));

            return result;
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(n => $"{n.FirstName} {n.LastName}")
                .OrderBy(n => n)
                .ToList();

            var result = string.Join(Environment.NewLine, authors);

            return result;
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Select(t => t.Title)
                .Where(t => t.ToLowerInvariant().Contains(input.ToLower()))
                .OrderBy(t => t)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(a => EF.Functions.Like(a.Author.LastName, $"{input}%")) //.Where(a => a.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(x => new
                {
                    Title = x.Title,
                    BookId = x.BookId,
                    FullName = $"{x.Author.FirstName} {x.Author.LastName}"
                }).ToList()
                .OrderBy(b => b.BookId)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x => $"{x.Title} ({x.FullName})"));

            return result;
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCount = context.Books
                .Count(b => b.Title.Length > lengthCheck);

            return booksCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Sum(c => c.Copies)
                })
                .OrderByDescending(c => c.Copies)
                .ToList();

            var result = string.Join(Environment.NewLine, authors.Select(a => $"{a.FullName} - {a.Copies}"));

            return result;
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    TotalProfit = c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
                })
                .OrderByDescending(p => p.TotalProfit)
                .ThenBy(n => n.Name)
                .ToList();

            var result = string.Join(Environment.NewLine, categories.Select(c => $"{c.Name} ${c.TotalProfit:F2}"));

            return result;
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks.Select(b => new
                    {
                        TopTitles = b.Book.Title,
                        Year = b.Book.ReleaseDate
                    })
                    .OrderByDescending(d => d.Year)
                    .Take(3)
                    .ToList()
                })
                .OrderBy(c => c.CategoryName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.TopTitles} ({book.Year.Value.Year})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            context.Books
                .Where(d => d.ReleaseDate.Value.Year < 2010)
                .Update(x => new Models.Book() { Price = x.Price + 5 });  //Z.EntityFramework.Plus.EFCore
            //така праща 1 заявка само

            //foreach (var book in books)
            //{
            //    book.Price += 5;
            //}
            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var affectedRows = context.Books
                .Where(c => c.Copies < 4200)
                .Delete();

            //int affectedRows = context.SaveChanges();

            return affectedRows;
        }
    }
}
