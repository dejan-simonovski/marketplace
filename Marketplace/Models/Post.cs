using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int YearOfProduction { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Price { get; set; }

        public string ImagePath { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
