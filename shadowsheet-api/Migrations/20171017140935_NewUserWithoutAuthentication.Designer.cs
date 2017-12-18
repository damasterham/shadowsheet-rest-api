﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShadowAPI.Models;
using ShadowAPI.Models.Enums;
using System;

namespace ShadowAPI.Migrations
{
    [DbContext(typeof(RunnerContext))]
    [Migration("20171017140935_NewUserWithoutAuthentication")]
    partial class NewUserWithoutAuthentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ShadowSheet")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShadowAPI.Models.AdeptPower", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("AdeptPower");
                });

            modelBuilder.Entity("ShadowAPI.Models.Alias", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("InfoID");

                    b.Property<bool>("IsPrimary");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("InfoID");

                    b.ToTable("Alias");
                });

            modelBuilder.Entity("ShadowAPI.Models.Attributes", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Agility");

                    b.Property<int>("Body");

                    b.Property<int>("Charisma");

                    b.Property<int>("Edge");

                    b.Property<float>("Essence");

                    b.Property<int>("Intuition");

                    b.Property<int>("Logic");

                    b.Property<int>("Magic");

                    b.Property<int>("Reaction");

                    b.Property<int>("Resonance");

                    b.Property<int>("Strength");

                    b.Property<int>("Willpower");

                    b.HasKey("ID");

                    b.ToTable("Runner");
                });

            modelBuilder.Entity("ShadowAPI.Models.Contact", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Connection");

                    b.Property<string>("Favor");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ShadowAPI.Models.Info", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<string>("Description");

                    b.Property<string>("Ethnicity");

                    b.Property<string>("ImageURL");

                    b.Property<byte>("Metatype");

                    b.Property<string>("RealName");

                    b.Property<string>("Sex");

                    b.HasKey("ID");

                    b.ToTable("Runner");
                });

            modelBuilder.Entity("ShadowAPI.Models.License", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Nothing");

                    b.Property<long?>("SINID");

                    b.HasKey("ID");

                    b.HasIndex("SINID");

                    b.ToTable("License");
                });

            modelBuilder.Entity("ShadowAPI.Models.Metamagic", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Metamagic");
                });

            modelBuilder.Entity("ShadowAPI.Models.Quality", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ContradictorID");

                    b.Property<int>("Cost");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPositive");

                    b.Property<int>("Modifier");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ContradictorID");

                    b.ToTable("Quality");
                });

            modelBuilder.Entity("ShadowAPI.Models.Ritual", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Ritual");
                });

            modelBuilder.Entity("ShadowAPI.Models.Runner", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Runner");
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerContact", b =>
                {
                    b.Property<long>("RunnerID");

                    b.Property<long>("ContactID");

                    b.Property<int>("Loyalty");

                    b.HasKey("RunnerID", "ContactID");

                    b.HasIndex("ContactID");

                    b.ToTable("RunnerContact");
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerQuality", b =>
                {
                    b.Property<long>("RunnerID");

                    b.Property<long>("QualityID");

                    b.Property<int?>("Rank");

                    b.HasKey("RunnerID", "QualityID");

                    b.ToTable("RunnerQuality");
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerSkill", b =>
                {
                    b.Property<long>("RunnerID");

                    b.Property<long>("SkillID");

                    b.Property<int>("Rating");

                    b.HasKey("RunnerID", "SkillID");

                    b.ToTable("RunnerSkill");
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerSkillSpecialization", b =>
                {
                    b.Property<long>("RunnerID");

                    b.Property<long>("SkillSpecializationID");

                    b.HasKey("RunnerID", "SkillSpecializationID");

                    b.HasIndex("SkillSpecializationID");

                    b.ToTable("RunnerSkillSpecialization");
                });

            modelBuilder.Entity("ShadowAPI.Models.SIN", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("SIN");
                });

            modelBuilder.Entity("ShadowAPI.Models.Skill", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActiveType");

                    b.Property<byte>("Group");

                    b.Property<int?>("KnowledgeType");

                    b.Property<string>("Name");

                    b.Property<byte>("Type");

                    b.HasKey("ID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("ShadowAPI.Models.SkillSpecialization", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long?>("SkillID");

                    b.HasKey("ID");

                    b.HasIndex("SkillID");

                    b.ToTable("SkillSpecialization");
                });

            modelBuilder.Entity("ShadowAPI.Models.Spell", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Drain");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Spell");
                });

            modelBuilder.Entity("ShadowAPI.Models.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsEmailUsername");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ShadowAPI.Models.Alias", b =>
                {
                    b.HasOne("ShadowAPI.Models.Info")
                        .WithMany("Aliases")
                        .HasForeignKey("InfoID");
                });

            modelBuilder.Entity("ShadowAPI.Models.Attributes", b =>
                {
                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithOne("Attributes")
                        .HasForeignKey("ShadowAPI.Models.Attributes", "ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.Info", b =>
                {
                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithOne("Info")
                        .HasForeignKey("ShadowAPI.Models.Info", "ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.License", b =>
                {
                    b.HasOne("ShadowAPI.Models.SIN")
                        .WithMany("Licenses")
                        .HasForeignKey("SINID");
                });

            modelBuilder.Entity("ShadowAPI.Models.Quality", b =>
                {
                    b.HasOne("ShadowAPI.Models.Quality", "Contradictor")
                        .WithMany()
                        .HasForeignKey("ContradictorID");
                });

            modelBuilder.Entity("ShadowAPI.Models.Runner", b =>
                {
                    b.HasOne("ShadowAPI.Models.User", "User")
                        .WithMany("Runners")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerContact", b =>
                {
                    b.HasOne("ShadowAPI.Models.Contact", "Contact")
                        .WithMany("Runners")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithMany("Contacts")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerQuality", b =>
                {
                    b.HasOne("ShadowAPI.Models.Quality", "Quality")
                        .WithMany("Runners")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithMany("Qualities")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerSkill", b =>
                {
                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithMany("Skills")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShadowAPI.Models.Skill", "Skill")
                        .WithMany("Runners")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.RunnerSkillSpecialization", b =>
                {
                    b.HasOne("ShadowAPI.Models.Runner", "Runner")
                        .WithMany("SkillSpecializations")
                        .HasForeignKey("RunnerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShadowAPI.Models.SkillSpecialization", "SkillSpecialization")
                        .WithMany("Runners")
                        .HasForeignKey("SkillSpecializationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShadowAPI.Models.SkillSpecialization", b =>
                {
                    b.HasOne("ShadowAPI.Models.Skill", "Skill")
                        .WithMany("Spectialization")
                        .HasForeignKey("SkillID");
                });
#pragma warning restore 612, 618
        }
    }
}