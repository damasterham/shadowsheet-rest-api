using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShadowAPI.Models
{
    public class RunnerContext : DbContext
    {
        public RunnerContext (DbContextOptions<RunnerContext> options)
            : base(options)
        {
        }

        public DbSet<Runner> Runner { get; set; }
        public DbSet<Info> Info { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Runner>()
                .HasOne(x => x.Info)
                .WithOne(x => x.Runner)
                .HasForeignKey<Info>(x => x.ID);
            modelBuilder.Entity<Runner>().ToTable("Runner");
            modelBuilder.Entity<Info>().ToTable("Runner");
        }
    }
}
