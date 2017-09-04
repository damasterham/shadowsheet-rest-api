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

        public DbSet<AdeptPower> AdeptPower { get; set; }
        public DbSet<Alias> Alias { get; set; }
        public DbSet<Awakened> Awakened { get; set; }
        public DbSet<Contact> Contact { get; set; }

        public DbSet<SIN> SIN { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<Metamagic> Metamagic { get; set; }
        public DbSet<Quality> Quality { get; set; }
        public DbSet<Ritual> Ritual { get; set; }

        public DbSet<Runner> Runner { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Info> Info { get; set; }

        public DbSet<RunnerContact> RunnerContact { get; set; } // Can this be skipped?

        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillSpecialization> SkillSpecialization { get; set; }
        public DbSet<Spell> Spell { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            // Attributes -> Runner
            modelBuilder.Entity<Runner>()
                .HasOne(x => x.Attributes)
                .WithOne(x => x.Runner)
                .HasForeignKey<Attributes>(x => x.ID);

            // Info -> Runner
            modelBuilder.Entity<Runner>()
                .HasOne(x => x.Info)
                .WithOne(x => x.Runner)
                .HasForeignKey<Info>(x => x.ID);

            modelBuilder.Entity<Runner>().ToTable("Runner");
            modelBuilder.Entity<Attributes>().ToTable("Runner");
            modelBuilder.Entity<Info>().ToTable("Runner");


            //RunnerContact Many to Many relationship
            modelBuilder.Entity<RunnerContact>()
                .HasKey(rc => new { rc.RunnerID, rc.ContactID });

            modelBuilder.Entity<RunnerContact>()
                .HasOne(rc => rc.Runner)
                .WithMany(r => r.Contacts)
                .HasForeignKey(rc => rc.RunnerID);

            modelBuilder.Entity<RunnerContact>()
                .HasOne(rc => rc.Contact)
                .WithMany(c => c.Runners)
                .HasForeignKey(rc => rc.ContactID);



        }
    }
}
