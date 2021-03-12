using LibraryModels;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace StoreDL
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions options) : base(options)
        {
        }
        protected LibraryDBContext()
        {
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(customer => customer.CustomerID)
                .ValueGeneratedOnAdd();
        }
    }
}
