using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShadowAPI.Services;
using System.Reflection;

namespace ShadowAPI.Models
{
    public class RunnerContext : DbContext
    {
        private ICollection<Type> _entityClasses = new List<Type>(
            ReflectionTools.GetTypes(Assembly.GetExecutingAssembly(), "ShadowAPI.Models"));

        //ICollection<Type> _entityClasses = new List<Type>(ReflectionTools.GetTypes(ass, "ShadowAPI.Models"));

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
            // Define Default Schema
            modelBuilder.HasDefaultSchema("ShadowSheet");

            // Excluded Entities
            modelBuilder.Ignore<Item>();
            modelBuilder.Ignore<Weapon>();


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

            // Awakened <-> Runner


            // Attributes & Info bind to Runner table
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
                .HasForeignKey(rs => rs.ContactID);



            //RunnerContact Many to Many relationship
            // Doesn't have to be many to many
            modelBuilder.Entity<RunnerSkill>()
                .HasKey(rs => new { rs.RunnerID, rs.SkillID });

            modelBuilder.Entity<RunnerSkill>()
                .HasOne(rs => rs.Runner)
                .WithMany(r => r.Skills)
                .HasForeignKey(rs => rs.RunnerID);

            modelBuilder.Entity<RunnerSkill>()            //Should remove many relationship with? 
                .HasOne(rs => rs.Skill)
                .WithMany(s => s.Runners)
                .HasForeignKey(rs => rs.RunnerID);



            //RunnerSkillSpecialization Many to Many relationship
            modelBuilder.Entity<RunnerSkillSpecialization>()
                .HasKey(rss => new { rss.RunnerID, rss.SkillSpecializationID });

            modelBuilder.Entity<RunnerSkillSpecialization>()
                .HasOne(rss => rss.SkillSpecialization)
                .WithMany(ss => ss.Runners);

            modelBuilder.Entity<RunnerSkillSpecialization>()
                .HasOne(rss => rss.Runner)
                .WithMany(r => r.SkillSpecializations);
                  

            //Runner has Skill
            //Runner has Skill with SS's
            //Skill has SS's
            //


        }
    }
}
