using System.ComponentModel.DataAnnotations;

namespace MvcWebExample_Data.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
