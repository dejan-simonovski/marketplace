using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
