using Marketplace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
