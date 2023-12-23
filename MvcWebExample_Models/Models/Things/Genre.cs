using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.Things
{
    [Table("tb_genres")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [Column("Name")]
        public string GenreName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
