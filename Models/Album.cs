using System.ComponentModel.DataAnnotations.Schema;

namespace Albums.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public string? GenreName { get; set; }
    }
}
