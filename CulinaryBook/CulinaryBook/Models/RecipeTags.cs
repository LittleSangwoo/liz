using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class RecipeTags
    {
        [Key]
        public int RecipeTagID { get; set; }
        [Required]
        public int RecipeID { get; set; }
        [Required]
        public int TagID { get; set; }
    }
}
