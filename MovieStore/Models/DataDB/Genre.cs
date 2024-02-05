using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DataDB
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}
