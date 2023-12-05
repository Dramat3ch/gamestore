using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "Need for Speed: Most Wanted" },
                new Game { Id = 2, Name = "The Witcher 3: Wild Hunt" },
                new Game { Id = 3, Name = "S.T.A.L.K.E.R.: Shadow of Chernobyl" }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "rpg" },
                new Genre { Id = 2, Name = "racing" },
                new Genre { Id = 3, Name = "fps" }
            );
            modelBuilder.Entity<Game>()
                .HasMany(game => game.Genres)
                .WithMany(genre => genre.Games)
                .UsingEntity(builder => builder.HasData(
                    new { GamesId = 1, GenresId = 2 },
                    new { GamesId = 2, GenresId = 1 },
                    new { GamesId = 3, GenresId = 3 }));
        }
    }
}