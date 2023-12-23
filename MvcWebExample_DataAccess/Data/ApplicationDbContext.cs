using Microsoft.EntityFrameworkCore;
using MvcWebExample_Data.Models.People;
using MvcWebExample_Data.Models.Things;

namespace MvcWebExample_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<SubCategories> SubCategories { get; set; }

        public DbSet<Fluent_BookDetail> BookDetail_fluent { get; set; }

        public DbSet<Fluent_Book> Fluent_Books { get; set; }

        public DbSet<Fluent_Author> Fluent_Authors { get; set; }
        
        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            // define with options what is the type of database we want via the connection string from the DB            
            var serverName = "(LocalDb)\\MSSQLLocalDB";
            var connectionString = $"Server={serverName};Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=true";
            options.UseSqlServer(connectionString);
        }

        // when we set create a model for the database, we can set some rules here through the ModelBuilder tool
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fluent_BookDetail>().HasKey(fbd => fbd.BookDetail_Id); // like [Key]: set primary key here, not in the class
            modelBuilder.Entity<Fluent_BookDetail>().ToTable("Fluent_BookDetail"); // rename a table
            modelBuilder.Entity<Fluent_BookDetail>().Property(fbd => fbd.NumberOfChapters).HasColumnName("NoOfChapters"); // rename a table's column
            modelBuilder.Entity<Fluent_BookDetail>().Property(fbd => fbd.NumberOfChapters).IsRequired(); // like [Required]
            modelBuilder.Entity<Fluent_BookDetail>().Property(fbd => fbd.Weight).HasMaxLength(10); // like [MaxLength]
            modelBuilder.Entity<Fluent_BookDetail>().Ignore(fbd => fbd.NumberOfPages); // like [NotMapped]

            // define a one-to-one relation between two models through their foreign keys
            modelBuilder.Entity<Fluent_BookDetail>().HasOne(fbd => fbd.Book).WithOne(fb => fb.BookDetail).HasForeignKey<Fluent_BookDetail>(u => u.BookId);

            modelBuilder.Entity<Fluent_Book>().HasKey(fb => fb.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Ignore(fb => fb.Price);            
            modelBuilder.Entity<Fluent_Book>().Property(fb => fb.ISBN).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(fb => fb.ISBN).HasMaxLength(50);
            modelBuilder.Entity<Fluent_Book>().HasOne(fb => fb.Publisher).WithMany(fp => fp.Books).HasForeignKey(fb => fb.Publisher_Id);

            modelBuilder.Entity<Fluent_Publisher>().HasKey(fb => fb.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(fb => fb.Name).IsRequired();

            modelBuilder.Entity<Fluent_Author>().HasKey(fa => fa.Author_Id);
            modelBuilder.Entity<Fluent_Author>().Property(fa => fa.FirstName).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(fa => fa.LastName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(fa => fa.FullName);

            // modelBuilder.Entity<BookAuthorMap>().HasKey( c => new { c.Author_Id, c.Book_Id} ); // set a composite/common key
            modelBuilder.Entity<Book>().Property(b => b.Price).HasPrecision(10,2);                        

            AddModelObjects(modelBuilder);            
        }

        private void AddModelObjects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Book_Id = 1,
                ISBN = "123123",
                Price = 10,
                Title = "Harry Potter 1",
                Publisher_Id = 1,
            },
            new Book
            {
                Book_Id = 2,
                ISBN = "121123",
                Price = 11,
                Title = "Harry Potter 2",
                Publisher_Id = 1,
            });

            modelBuilder.Entity<Publisher>().HasData(new Publisher
            {
                // Name = "House Public",
                Publisher_Id = 1,
                Location = "Athens",
            });
        }
    }
}