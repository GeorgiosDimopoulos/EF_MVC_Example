using MvcWebExample_Data.Models.People;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.Things
{
    public class Fluent_Book
    {
        [Key]
        public int Book_Id { get; set; }
                
        public string Title { get; set; }

        [MaxLength(30)]
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }
                                                
        public Fluent_BookDetail BookDetail { get; set; }

        //[ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        public Fluent_Publisher Publisher { get; set; }

        //public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
    }
}
