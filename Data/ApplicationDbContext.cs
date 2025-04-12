using IPT_MVC_Activity.Models;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext() // Parameterless constructor for design time
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure your database connection here for design time
                optionsBuilder.UseSqlite("Data Source=YourDesignTimeDatabase.db"); // Example for SQLite
                // Or for SQL Server:
                // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YourDesignTimeDatabase;Trusted_Connection=True;");
            }
        }


        public DbSet<Miniature> Miniatures { get; set; }
    }

    public class User  
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
