using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class Ingredients
    {
        [Key]
        public int IngredientID { get; set; }
        [Required]
        [StringLength(255)]
        public string? IngredientName { get; set; }

        public ICollection<RecipeIngredients>? RecipeIngredients { get; set; }

    }
}
