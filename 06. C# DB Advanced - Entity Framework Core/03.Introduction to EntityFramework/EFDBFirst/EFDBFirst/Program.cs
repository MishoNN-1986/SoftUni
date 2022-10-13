using EFDBFirst.Data2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Linq;

namespace EFDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/ef/core/cli/powershell
            //Package Manager Console
            //Scaffold-DbContext -Connection "Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = SoftUni;Integrated Security = true" 
            //-OutputDir Data -Provider Microsoft.EntityFrameworkCore.SqlServer

            //Data2 with DataAnnotations
            //Scaffold-DbContext -Connection "Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = SoftUni;Integrated Security = true" -OutputDir Data2 
            //-Provider Microsoft.EntityFrameworkCore.SqlServer -DataAnnotations
            //Microsoft.EntityFrameworkCore.Proxies

            LoggerFactory SqlCommandLoggerFactory
                = new LoggerFactory(new[]
                {
                                new ConsoleLoggerProvider((category, level)
                                => category == DbLoggerCategory.Database.Command.Name
                                && level == LogLevel.Information, true)});

            DbContextOptionsBuilder<SoftUniContext> optionBuilder = new DbContextOptionsBuilder<SoftUniContext>();

            optionBuilder.UseSqlServer(@"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = SoftUni;Integrated Security = true")
            .UseLoggerFactory(SqlCommandLoggerFactory)
            .EnableSensitiveDataLogging() // за да видим информацията
            .UseLazyLoadingProxies(); // вкл. го на всякъде

            using (var contex = new SoftUniContext(optionBuilder.Options)) // changetracker
            {
                //var emp = contex.Employees
                //    .Include(e => e.Department) // lazy loading, без него ще даде грешка за e.Department, прави JOIN
                //    .FirstOrDefault();

                //emp.FirstName = "Pesho"; // променяме името
                //emp.LastName = "Ivanov";

                //contex.SaveChanges();

                //----------------------------------------------------------------------

                //var project = new Projects()
                //{
                //    Description = "Igra",
                //   Name = "Ime",
                //   StartDate = DateTime.Now
                //};

                //contex.Projects.Add(project);
                //contex.SaveChanges();

                //----------------------------------------------------------------------------

                //Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.Department.Name}");

                //-------------------------------------------------------------------------------

                //var addresses = new Address()
                //{
                //    AddressText = "Vitosha 12",
                //    Town = new Towns()
                //    {
                //        Name = "Svoge"
                //    }
                //};

                //contex.Addresses.Add(addresses);
                //contex.SaveChanges();

                //---------------------------------------------------------------------

                //var town = contex.Towns.FirstOrDefault();

                //var address = new Address()
                //{
                //    AddressText = "Vasil Levski 12",
                //    Town = town
                //};

                //contex.Addresses.Add(address); // в първия град добавя текста
                //contex.SaveChanges();

                //--------------------------------------------------------------------

                //var town = contex.Towns
                //    .Include(t => t.Addresses)
                //    .FirstOrDefault(t => t.Name == "Svoge");

                //contex.RemoveRange(town.Addresses); // премахваме всички адреси закачени към града, и след това премахваме града
                //contex.Towns.Remove(town);
                //contex.SaveChanges();

                //-------------------------------------------------------------------------

                //var town = contex.Towns.FirstOrDefault();

                //town.Addresses.Add(new Address() { AddressText = "Oborishte 34" });

                //contex.SaveChanges();

                //------------------------------------------------------------------------------------

                //var town = contex.Towns.FirstOrDefault();

                //contex.ChangeTracker.LazyLoadingEnabled = true; // вкл. го само за този contex

                var emp = contex.Employees.FirstOrDefault();

                //var emp = contex.Employees
                    //.Include(e => e.Department)
                    //.FirstOrDefault();

                Console.WriteLine($"{emp.FirstName}, {emp.Department.Name}");
            }
        }
    }
}



