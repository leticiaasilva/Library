using System.Collections.Generic;
using System.Reflection.Emit;
using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public ISet<Book> Books { get; set; }

    }
}