using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sut_Iulia_Lab2.Models;

namespace Sut_Iulia_Lab2.Data
{
    public class Sut_Iulia_Lab2Context : DbContext
    {
        public Sut_Iulia_Lab2Context (DbContextOptions<Sut_Iulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sut_Iulia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sut_Iulia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Sut_Iulia_Lab2.Models.Author> Authors { get; set; } = default!;
    }
}
