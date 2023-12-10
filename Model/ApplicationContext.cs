using Microsoft.EntityFrameworkCore;

namespace Library.Model
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Genre> Genre { get; set; }
        //public DbSet<Worker> Librarian { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Book> Book { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=library;Username=postgres;Password=1234");
        }
    }
}
