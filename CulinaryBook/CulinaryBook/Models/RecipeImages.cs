using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class RecipeImages
    {
        [Key]
        public int ImageID { get; set; }
        [Required]
        public int RecipeID { get; set; }
        [Required]
        [StringLength(50)]
        public string? ImagePath { get; set; }

    }
}
