using EFCodeFirst.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Linq;

namespace EFCodeFirst2
{
    class Program
    {
        static void Main(string[] args)
        {


            //class library !
            //Database = BlogDB - името на новата база
            //package manager console
            //default project: migration project
            //add-migration InitialMigration(име, какво прави), ако добавим нова миграция ни изкарава само промените
            //- Context [name] (ако имаме повече от 1)
            //стартиращият ни проект да е start up project -> дясно копче и set as start up project 
            //update-database, след всеки add-migration
            //ако има грешка - сменяме ги на ReferentialAction.NoAction
            // Remove-Migration трие само последната 

            LoggerFactory SqlCommandLoggerFactory
                = new LoggerFactory(new[]
                {
                                new ConsoleLoggerProvider((category, level)
                                => category == DbLoggerCategory.Database.Command.Name
                                && level == LogLevel.Information, true)});

            string connectionString = @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = BlogDB;Integrated Security = true";
            DbContextOptionsBuilder<BlogDbContext> optionBuilder = new DbContextOptionsBuilder<BlogDbContext>();

            optionBuilder.UseSqlServer(connectionString, s => s.MigrationsAssembly("EFCodeFirst.Infrastructure"))
            .UseLoggerFactory(SqlCommandLoggerFactory)
            .EnableSensitiveDataLogging();

            //using (var context = new BlogDbContext())
            //{
            //    var user = context.Users.FirstOrDefault();
            //}
        }
    }
}
