using JP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JP.Data
{
   public class GoodBooksDBContext: DbContext
    {
        public GoodBooksDBContext() { }

        public GoodBooksDBContext(DbContextOptions options): base(options) { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookReview> BookReviews { get; set; }
    }
}
