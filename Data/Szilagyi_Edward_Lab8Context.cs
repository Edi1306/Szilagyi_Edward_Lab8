using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Szilagyi_Edward_Lab8.Models;

namespace Szilagyi_Edward_Lab8.Data
{
    public class Szilagyi_Edward_Lab8Context : DbContext
    {
        public Szilagyi_Edward_Lab8Context (DbContextOptions<Szilagyi_Edward_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Szilagyi_Edward_Lab8.Models.Book> Book { get; set; }

        public DbSet<Szilagyi_Edward_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Szilagyi_Edward_Lab8.Models.Category> Category { get; set; }
    }
}
