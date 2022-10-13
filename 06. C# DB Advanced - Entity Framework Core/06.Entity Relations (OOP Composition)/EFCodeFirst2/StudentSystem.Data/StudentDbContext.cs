using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {

        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)// тук е fluent API
        {
            modelBuilder
                .Entity<Student>()
                .HasKey(s => s.StudentId);

            modelBuilder
                .Entity<Student>()
                .OwnsOne(s => s.Name);// защото Name няма id
                                      //.ToTable("PersonNames");// може да направи отделна таблица, но не можем да работим с нея защото нямаме id
                                      //.Property(s => s.FirstName)////може и с атрибут в класа(1 ред е само)
                                      //.HasColumnName("FirstName"); // сменя името

            //modelBuilder
            //    .Entity<Student>()
            //.HasData(); //не позволява да се върви по релациите(не се ползва върху navigation property)

            modelBuilder
                .Entity<Course>()
                .HasData(new Course[]
                {
                    new Course()
                    {
                        CourseId = 1,
                        Name = "Entity Framework",
                        Description = "Testing",
                        StartDate =new DateTime(2020, 1, 20),
                        EndDate = new DateTime(2020, 3, 25)
                    }
                });
            modelBuilder.Entity<Resource>().HasData(new Resource[]
            {
                new Resource()
                {
                    ResourceId = 1,
                    CourseId = 1,
                    Name = "Presentation",
                    ResourceType = ResourceType.Presentation,
                    Url ="www.studensystem.my/presentation"
                }
            });

            modelBuilder
                .Entity<StudentCourse>()
                .HasKey(s => new { s.StudentId, s.CourseId }); //композитен ключ, чрез анонимен обект
            // не се описва като dbset
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            LoggerFactory SqlCommandLoggerFactory
                = new LoggerFactory(new[]
                {
                                new ConsoleLoggerProvider((category, level)
                                => category == DbLoggerCategory.Database.Command.Name
                                && level == LogLevel.Information, true)
                });

            optionsBuilder.UseSqlServer("Server = DESKTOP-MFH0NH3\\SQLEXPRESS;Database = StudentSystemDB;Integrated Security = true",
                        s => s.MigrationsAssembly("StudentSystem.Data"))
                        .UseLoggerFactory(SqlCommandLoggerFactory)
                        .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Resource> Resources { get; set; }
    }
}
