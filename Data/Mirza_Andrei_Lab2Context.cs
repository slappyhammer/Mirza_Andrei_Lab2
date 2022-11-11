using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mirza_Andrei_Lab2.Models;

namespace Mirza_Andrei_Lab2.Data
{
    public class Mirza_Andrei_Lab2Context : DbContext
    {
        public Mirza_Andrei_Lab2Context (DbContextOptions<Mirza_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mirza_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Mirza_Andrei_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Mirza_Andrei_Lab2.Models.Category> Category { get; set; }

        public DbSet<Mirza_Andrei_Lab2.Models.Author> Author { get; set; }
    }
}
