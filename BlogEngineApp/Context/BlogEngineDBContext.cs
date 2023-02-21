using BlogEngineApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace BlogEngineApp.Context
{
    public class BlogEngineDBContext : IdentityDbContext<ApplicationUser>
    {
        public BlogEngineDBContext()
        {
        }

        public BlogEngineDBContext(DbContextOptions<BlogEngineDBContext> options)
        : base(options)
        {

        }
       
        public virtual DbSet<Posts> Posts { get; set; }
      
        public DbSet<BlogEngineApp.Models.Coments> Coments { get; set; } = default!;

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.seed();
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
