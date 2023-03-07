using Microsoft.EntityFrameworkCore;

namespace BlogEngine.Models
{
    public class BlogEngineContext : DbContext
    {
        public BlogEngineContext(DbContextOptions<BlogEngineContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
