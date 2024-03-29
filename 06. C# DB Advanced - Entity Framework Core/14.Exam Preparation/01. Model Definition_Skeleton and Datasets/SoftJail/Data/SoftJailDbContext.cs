﻿namespace SoftJail.Data
{
    using Microsoft.EntityFrameworkCore;
    using SoftJail.Data.Models;

    public class SoftJailDbContext : DbContext
    {
        public SoftJailDbContext()
        {
        }

        public SoftJailDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Prisoner> Prisoners { get; set; }

        public DbSet<Officer> Officers { get; set; }

        public DbSet<Mail> Mails { get; set; }

        public DbSet<Cell> Cells { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<OfficerPrisoner> OfficerPrisoners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<OfficerPrisoner>(entity =>
                {
                    entity.HasKey(op => new { op.OfficerId, op.PrisonerId });

                    entity
                    .HasOne(op => op.Prisoner)
                    .WithMany(p => p.PrisonerOfiicers)
                    .HasForeignKey(op => op.PrisonerId);

                    entity
                    .HasOne(op => op.Officer)
                    .WithMany(o => o.OfficerPrisoners)
                    .HasForeignKey(op => op.OfficerId);
                });
        }
    }
}