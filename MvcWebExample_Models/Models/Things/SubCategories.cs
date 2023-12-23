using System.ComponentModel.DataAnnotations;

namespace MvcWebExample_Data.Models.Things
{
    public class SubCategories
    {
        [Key]
        public int SubCategory_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
