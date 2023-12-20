using Microsoft.EntityFrameworkCore;
using MvcWebExample_Data.Models;

namespace MvcWebExample_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // the name 'Books' should be the same as the name of the Table in the Database
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            // define with options what is the type of database we want via the connection string from the DB            
            // here the current database path is "C:\\Users\\georg\\source\\repos\\MvcWebExample.mdf"
            var serverName = "(LocalDb)\\MSSQLLocalDB";
            var connectionString = $"Server={serverName};Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=true";
            options.UseSqlServer(connectionString);
        }

        // when we set create a model for the database, we can set some rules here through the ModelBuilder tool
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().Property(b => b.Price).HasPrecision(10,2);
        }
    }
}