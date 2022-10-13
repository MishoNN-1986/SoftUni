using EfCodeF.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //class library !
            //package manager console
            //Database = BlogDB - името на новата база
            //default project: migration project
            //add-migration InitialMigration(име, какво прави)
            //- Context [name] (ако имаме повече от 1)
            //стартиращият ни проект да е start up project -> дясно копче и set as start up project 
            //update-database
            // Remove-Migration трие само последната 


            LoggerFactory SqlCommandLoggerFactory
                = new LoggerFactory(new[]
                {
                                new ConsoleLoggerProvider((category, level)
                                => category == DbLoggerCategory.Database.Command.Name
                                && level == LogLevel.Information, true)});

            string connectionString = @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = BlogDB;Integrated Security = true";
            DbContextOptionsBuilder<BlogDbContext> optionBuilder = new DbContextOptionsBuilder<BlogDbContext>();

            optionBuilder.UseSqlServer(connectionString, s => s.MigrationsAssembly("EfCodeF.Infrastructure"))
            .UseLoggerFactory(SqlCommandLoggerFactory)
            .EnableSensitiveDataLogging();
        }
    }
}
