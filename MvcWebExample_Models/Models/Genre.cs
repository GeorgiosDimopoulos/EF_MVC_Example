using System.ComponentModel.DataAnnotations;

namespace MvcWebExample_Data.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int Display { get; set; }                           
    }
}
