using BookstoreSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreSystem.Contexts
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Automatically applies all IEntityTypeConfiguration classes in the assembly
            // This is the clean / modular Fluent API approach (one config class per entity)
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookstoreDbContext).Assembly);
        }
    }
}
