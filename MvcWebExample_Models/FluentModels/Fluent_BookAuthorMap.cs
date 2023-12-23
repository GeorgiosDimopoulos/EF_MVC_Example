using MvcWebExample_Data.Models.People;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcWebExample_Data.Models.Things
{
    public class Fluent_BookAuthorMap
    {           
        //public Fluent_Book Book { get; set; }
        //public Fluent_Author Author { get; set; }

        // [ForeignKey("Author")]
        public int Author_Id { get; set; }

        // [ForeignKey("Book")]
        public int Book_Id { get; set; }

    }
}
