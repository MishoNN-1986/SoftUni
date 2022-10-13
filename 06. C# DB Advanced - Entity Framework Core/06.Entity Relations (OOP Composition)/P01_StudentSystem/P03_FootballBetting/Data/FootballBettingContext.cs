using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Config.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnConfiguringTeam(modelBuilder);

            OnConfiguringColor(modelBuilder);

            OnConfiguringTown(modelBuilder);

            OnConfiguringCountry(modelBuilder);

            OnConfiguringPlayer(modelBuilder);

            OnConfiguringPosition(modelBuilder);

            OnConfiguringPlayerStatistic(modelBuilder);

            OnConfiguringGame(modelBuilder);

            OnConfiguringBet(modelBuilder);

            OnConfiguringUser(modelBuilder);
        }

        private void OnConfiguringUser(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>(entity =>
                {
                    entity
                    .HasKey(e => e.UserId);
                });
        }

        private void OnConfiguringBet(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Bet>(entity =>
                {
                    entity
                    .HasKey(e => e.BetId);

                    entity
                    .HasOne(e => e.User)
                    .WithMany(u => u.Bets)
                    .HasForeignKey(e => e.UserId);

                    entity
                    .HasOne(e => e.Game)
                    .WithMany(g => g.Bets)
                    .HasForeignKey(e => e.GameId);
                });
        }

        private void OnConfiguringGame(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Game>(entity =>
                {
                    entity
                    .HasKey(e => e.GameId);

                    entity
                    .HasOne(e => e.HomeTeam)
                    .WithMany(ht => ht.HomeGames)
                    .HasForeignKey(e => e.HomeTeamId)
                    .OnDelete(DeleteBehavior.Restrict);

                    entity
                    .HasOne(e => e.AwayTeam)
                    .WithMany(at => at.AwayGames)
                    .HasForeignKey(e => e.AwayTeamId)
                    .OnDelete(DeleteBehavior.Restrict);
                });
        }

        private void OnConfiguringPlayerStatistic(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PlayerStatistic>(entity =>
                {
                    entity
                    .HasKey(e => new { e.GameId, e.PlayerId });

                    entity
                    .HasOne(e => e.Game)
                    .WithMany(g => g.PlayerStatistics)
                    .HasForeignKey(e => e.GameId);

                    entity
                    .HasOne(e => e.Player)
                    .WithMany(p => p.PlayerStatistics)
                    .HasForeignKey(e => e.PlayerId);
                });
        }

        private void OnConfiguringPosition(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Position>(entity =>
                {
                    entity
                    .HasKey(e => e.PositionId);
                });
        }

        private void OnConfiguringPlayer(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Player>(entity =>
                {
                    entity
                    .HasKey(e => e.PlayerId);

                    entity
                    .HasOne(e => e.Team)
                    .WithMany(t => t.Players)
                    .HasForeignKey(e => e.TeamId);

                    entity
                    .HasOne(e => e.Position)
                    .WithMany(p => p.Players)
                    .HasForeignKey(e => e.PositionId);
                });
        }

        private void OnConfiguringCountry(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Country>(entity =>
                {
                    entity
                    .HasKey(e => e.CountryId);
                });
        }

        private void OnConfiguringTown(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Town>(entity =>
                {
                    entity
                    .HasKey(e => e.TownId);

                    entity
                    .HasOne(e => e.Country)
                    .WithMany(c => c.Towns)
                    .HasForeignKey(e => e.CountryId);
                });
        }

        private void OnConfiguringColor(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Color>(entity =>
                {
                    entity
                    .HasKey(e => e.ColorId);
                });
        }

        private void OnConfiguringTeam(ModelBuilder modelBuilder)
        {
            modelBuilder
                 .Entity<Team>(entity =>
                 {
                     entity
                     .HasKey(e => e.TeamId);

                     entity
                     .Property(e => e.Initials)
                     .HasColumnType("CHAR(3)")
                     .IsRequired();

                     entity
                     .HasOne(e => e.PrimaryKitColor)
                     .WithMany(p => p.PrimaryKitTeams)
                     .HasForeignKey(e => e.PrimaryKitColorId)
                     .OnDelete(DeleteBehavior.Restrict);

                     entity
                     .HasOne(e => e.SecondaryKitColor)
                     .WithMany(s => s.SecondaryKitTeams)
                     .HasForeignKey(e => e.SecondaryKitColorId)
                     .OnDelete(DeleteBehavior.Restrict);

                     entity
                     .HasOne(e => e.Town)
                     .WithMany(t => t.Teams)
                     .HasForeignKey(e => e.TeamId);
                 });
        }
    }
}
