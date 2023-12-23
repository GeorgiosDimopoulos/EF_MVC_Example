using MvcWebExample_Data.Models.Things;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebExample_Data.Models.People
{
    public class Author
    {
        [Key]
        public int Author_Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Location { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Book> Books { get; set; }
        // public List<BookAuthorMap> BookAuthor { get; set; }
    }
}
