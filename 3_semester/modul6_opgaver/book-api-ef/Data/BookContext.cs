using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();


        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}