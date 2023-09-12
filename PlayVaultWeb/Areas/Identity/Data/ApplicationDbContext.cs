using Microsoft.EntityFrameworkCore;
using PlayVaultWeb.Models;
using System.Reflection.Emit;

namespace PlayVaultWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<Dictionary<string, object>>(
                "UserRoles",
                ur => ur.HasOne<Role>().WithMany(),
                ur => ur.HasOne<User>().WithMany()
            );
        }
        
    }
}
