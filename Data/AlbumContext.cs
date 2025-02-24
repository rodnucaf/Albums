using Albums.Models;
using Microsoft.EntityFrameworkCore;

namespace Albums.Data
{
    public class AlbumContext :DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext>options) : base(options){ }   

        public DbSet<Album> Albums { get; set; }
        
    }
}
