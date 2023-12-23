using MvcWebExample_Data.Models.Things;
using System.ComponentModel.DataAnnotations;

namespace MvcWebExample_Data.Models.People
{
    public class Publisher
    {
        [Key]
        public int Publisher_Id { get; set; }

        [Required]
        public string Name { get; }
        public string Location { get; set; }

        public List<Book> Books { get; set; } // navigation property, to publish all the books of the Publisher
    }
}
