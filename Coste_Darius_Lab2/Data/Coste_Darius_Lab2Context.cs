using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coste_Darius_Lab2.Models;

namespace Coste_Darius_Lab2.Data
{
    public class Coste_Darius_Lab2Context : DbContext
    {
        public Coste_Darius_Lab2Context (DbContextOptions<Coste_Darius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coste_Darius_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Coste_Darius_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
