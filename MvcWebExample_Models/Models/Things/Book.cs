using MvcWebExample_Data.Models.People;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.Things
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
                
        public string Title { get; set; }

        [MaxLength(30)]
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; } // not for DataBase, only for UI
                                                
        public BookDetail BookDetail { get; set; } // we dont need to set here also a foreign key from BookDetail class, EF already knows that

        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }

        public List<Author> Authors { get; set; }
        // public List<BookAuthorMap> BookAuthor { get; set; }
    }
}
