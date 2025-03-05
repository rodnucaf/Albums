using Albums.Models;
using Microsoft.EntityFrameworkCore;

namespace Albums.Data
{
    public class AlbumContext :DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext>options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre {Id = 1, Name="Rock"},
                new Genre {Id = 2, Name="Shoegaze"},
                new Genre {Id=3, Name="Dreampop"}                
            );
        }

        public DbSet<Album> Albums { get; set; }
        
        public DbSet<Genre> Genres { get; set; }
    }
}
