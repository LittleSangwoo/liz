using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class CookingStep
    {
        [Key]
        public int StepID { get; set; }
        [Required]
        public int RecipeID { get; set; }
        [Required]
        public int StepNumbers { get; set; }
        [Required]
        [StringLength(255)]

        public string? StepDescription { get; set; }

    }
}
