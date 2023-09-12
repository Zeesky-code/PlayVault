using Microsoft.EntityFrameworkCore;
using PlayVaultWeb.Models;

namespace PlayVaultWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        
        
    }
}
