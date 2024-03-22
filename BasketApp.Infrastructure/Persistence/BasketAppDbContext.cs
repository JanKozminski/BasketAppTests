using BasketApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Persistence
{
    public class BasketAppDbContext : DbContext
    {
        public BasketAppDbContext(DbContextOptions<BasketAppDbContext> options) : base(options) {
            
        }
        public DbSet<Domain.Entities.City> Cities { get; set; }
        public DbSet<Domain.Entities.Conference> Conferences { get; set; }
        public DbSet<Domain.Entities.CurrentCoaches> Coaches { get; set; }
        public DbSet<Domain.Entities.Division> Divisions { get; set; }
        public DbSet<Domain.Entities.Game> Games { get; set; }
        public DbSet<Domain.Entities.HistoricalPlayer> HistoricalPlayers { get; set; }
        public DbSet<Domain.Entities.HistoricalTeam> HistoricalTeams { get; set; }
        public DbSet<Domain.Entities.Player> Players { get; set; }
        public DbSet<Domain.Entities.PlayerGameStats> PlayerGamesStats { get; set; }
        public DbSet<Domain.Entities.PlayerHistoryLink> PlayerHistoryLink { get; set; }
        public DbSet<Domain.Entities.State> States { get; set; }
        public DbSet<Domain.Entities.Team> Teams { get; set; }
        public DbSet<Domain.Entities.Comment> Comments { get; set; }
        public DbSet<Domain.Entities.TeamHistoryLink> TeamHistoryLink { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<PlayerHistoryLink>()
                .HasKey(phl => new { phl.HistoricalPlayerID, phl.HistoricalTeamID });

            modelBuilder.Entity<TeamHistoryLink>()
               .HasKey(phl => new { phl.HistoricalTeamID, phl.HistoricalPlayerID });

           modelBuilder.Entity<TeamHistoryLink>()
                .HasOne(c => c.HistoricalPlayer)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<TeamHistoryLink>()
                .HasOne(c => c.HistoricalTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PlayerHistoryLink>()
                .HasOne(c => c.HistoricalTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PlayerHistoryLink>()
                .HasOne(c => c.HistoricalPlayer)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Game>()
                .HasOne(g => g.Team1)
                .WithMany()
                .HasForeignKey(g => g.Team1ID)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Game>()
                .HasOne(g => g.Team2)
                .WithMany()
                .HasForeignKey(g => g.Team2ID)
                .OnDelete(DeleteBehavior.ClientCascade);


        }   
    }
}
