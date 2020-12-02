using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Peia_CarmenDenisa_Lab8.Models;

namespace Peia_CarmenDenisa_Lab8.Data
{
    public class Peia_CarmenDenisa_Lab8Context : DbContext
    {
        public Peia_CarmenDenisa_Lab8Context (DbContextOptions<Peia_CarmenDenisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Peia_CarmenDenisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Peia_CarmenDenisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Peia_CarmenDenisa_Lab8.Models.Category> Category { get; set; }

        public DbSet<Peia_CarmenDenisa_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
