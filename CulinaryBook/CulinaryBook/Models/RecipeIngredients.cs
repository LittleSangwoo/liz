using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CulinaryBook.Models
{
    public class RecipeIngredients
    {
        [Key]
        public int RecipeIngredientID { get; set; }

        [Required]
        public int RecipeID { get; set; }
        [ForeignKey("RecipeID")]
        public Recipes? Recipes { get; set; }

        [Required]
        public int IngedientID { get; set; }
        [ForeignKey("IngedientID")]
        public Ingredients? Ingedients { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
