using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test_Kiki.Models;

namespace Projekt_Kristian.Data
{
    public class Projekt_KristianContext : DbContext
    {
        public Projekt_KristianContext (DbContextOptions<Projekt_KristianContext> options)
            : base(options)
        {
        }

        public DbSet<Test_Kiki.Models.Narudžba> Narudžba { get; set; }

        public DbSet<Test_Kiki.Models.Proizvod> Proizvod { get; set; }
    }
}
