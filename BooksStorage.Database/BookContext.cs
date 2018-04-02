using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStorage.Database.Models;

namespace BooksStorage.Database
{
    public class BookContext :DbContext
    {
        public BookContext()
            : base("BookContext")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
