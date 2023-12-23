using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.People
{
    public class Fluent_Author
    {
        // [Key]
        public int Author_Id { get; set; }

        // [MaxLength(50)]
        // [Required]
        public string FirstName { get; set; }

        // [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Location { get; set; }

        // [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        // public List<Fluent_Book> Books { get; set; }
        // public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
    }
}
