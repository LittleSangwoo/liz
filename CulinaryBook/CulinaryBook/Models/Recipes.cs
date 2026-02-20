using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CulinaryBook.Models
{
    public class Recipes
    {
        [Key]
        public int RecipeID { get; set; }
        [Required]
        [StringLength(100)]
        public string? RecipeName { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public int AuthorID { get; set; }
        [Required]
        public int CookingTime { get; set; }
        [StringLength(50)]
        public string? Image { get; set; }

    }
}
