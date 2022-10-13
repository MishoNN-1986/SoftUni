using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirst.Infrastructure.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext()
        {
        }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>() // при създаване на контекста ще добави данните, но само веднъж
            //    .HasData(new User()
            //    {
            //        Id = 1,
            //        FirstName = "Gosho",
            //        LastName = "Petrov"
            //    });

            //modelBuilder.Entity<User>()
            //    .Property(p => p.City)
            //    .HasDefaultValue("Sofia"); // дефолтна стойност на града, който добавихме като пропарти в user
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server = DESKTOP-MFH0NH3\\SQLEXPRESS;Database = BlogDB;Integrated Security = true",
                    s => s.MigrationsAssembly("EFCodeFirst.Infrastructure"));

                //optionsBuilder
                // .UseNpgsql("Host = DESKTOP-MFH0NH3\\SQLEXPRESS;Database = BlogDB;Integrated Security = true",
                // s => s.MigrationsAssembly("EFCodeFirst.Infrastructure")); // ако го правим в Npgsql
            }
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}
