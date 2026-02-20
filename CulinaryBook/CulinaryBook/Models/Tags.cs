using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class Tags
    {
        [Key]
        public int RecipeTagID { get; set; }
        [Required]
        [StringLength(50)]
        public string? TagName { get; set; }
    }
}
