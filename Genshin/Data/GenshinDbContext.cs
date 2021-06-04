using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Genshin.Models;

    public class GenshinDbContext : DbContext
    {
        public GenshinDbContext (DbContextOptions<GenshinDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genshin.Models.Weapon> Weapons { get; set; }
    }
