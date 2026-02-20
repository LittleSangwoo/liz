using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class Reviews
    {
        [Key]
        public int RecipeTagID { get; set; }
        [Required]
        public int RecipeID { get; set; }
        [Required]
        [StringLength(255)]
        public string? ReviewText { get; set; }
        [Required]
        [StringLength(255)]
        public string? Rating { get; set; }
    }
}
