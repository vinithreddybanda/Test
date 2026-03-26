using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entities
{
    public class EFCoreDbContext : DbContext
    {
        //The main class in EF Core for interacting with the database. It manages entity objects during runtime and handles database connections.
        // public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options): base(options)
        // {
        //      The constructor initializes the DbContext using the options provided, which typically include the database provider and connection string.
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // This method configures the DbContext, such as setting the database provider and connection string. It is useful if you don’t provide configuration externally.
            var conn = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build().GetConnectionString("DefaultConnection");

             optionsBuilder.UseSqlServer(conn);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }
        // These properties represent collections of entities that EF Core tracks. They correspond to tables in the database, and each entity type (like Student and Branch) maps to a DbSet.

        
    }
}