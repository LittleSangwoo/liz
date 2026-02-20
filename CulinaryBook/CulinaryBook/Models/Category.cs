using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(255)]
        public string? CategoryName { get; set; }
    }
}
