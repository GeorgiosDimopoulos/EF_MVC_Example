namespace MvcWebExample_Data.Models.Things
{
    public class Fluent_BookDetail
    {                     
        public int BookDetail_Id { get; set; }                
        
        public int NumberOfChapters { get; set; }
        
        public int NumberOfPages { get; set; }
        
        public string Weight {get; set; }            
        
        // [ForeignKey("Book")]
        public int BookId { get; set; }
        
        public Fluent_Book Book { get; set; } // parent navigation property
    }
}
