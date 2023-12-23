using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.Things
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }                
        
        public int NumberOfChapters { get; set; }
        
        public int NumberOfPages { get; set; }
        
        public string Weight {get; set; }            
        
        [ForeignKey("Book")]
        public int BookId { get; set; }
        
        public Book Book { get; set; } // navigation property for the foreign key of BookDetail
    }
}
