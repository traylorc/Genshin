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
        public DbSet<Genshin.Models.Element> Elements { get; set; }

        public DbSet<Genshin.Models.Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Character>().Property(c => c.Id).HasDefaultValueSql("NEWID()");

        builder.Entity<Weapon>(w => { w.HasIndex(p => p.WeaponType).IsUnique(); });

        builder.Entity<Element>(e => { e.HasIndex(m => m.Name).IsUnique(); });


    }


    }
