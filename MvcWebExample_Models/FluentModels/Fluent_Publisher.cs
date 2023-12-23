using MvcWebExample_Data.Models.Things;

namespace MvcWebExample_Data.Models.People
{
    public class Fluent_Publisher
    {
        // [Key]
        public int Publisher_Id { get; set; }

        // [Required]
        public string Name { get; }
        public string Location { get; set; }

        public List<Fluent_Book> Books { get; set; } // navigation property, to publish all the books of the Publisher
    }
}
