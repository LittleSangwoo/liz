using System.ComponentModel.DataAnnotations;

namespace CulinaryBook.Models
{
    public class Authors
    {
        [Key]
        public int AuthorID { get; set; }
        [Required]
        [StringLength(50)]
        public string? AuthorName { get; set; }
        [Required]
        [StringLength(50)]
        public string? Login { get; set; }
        [Required]
        [StringLength(50)]
        public string? Password { get; set; }

        
    }
}
