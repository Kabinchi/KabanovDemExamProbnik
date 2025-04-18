using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kabanov_DemExam_18052025.Models
{
    public partial class Kabanov_DemEx_18042025Context : DbContext
    {
        public Kabanov_DemEx_18042025Context()
        {
        }

        public Kabanov_DemEx_18042025Context(DbContextOptions<Kabanov_DemEx_18042025Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Detali_Zakaza> Detali_Zakaza { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Pizza_Ingredients> Pizza_Ingredients { get; set; }
        public virtual DbSet<Razmer_Pizza> Razmer_Pizza { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=hqvla3302s01\\KITP;Database=Kabanov_DemEx_18042025;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.Client_ID);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Detali_Zakaza>(entity =>
            {
                entity.HasKey(e => e.Detali_Zakaza_ID);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Pizza_)
                    .WithMany(p => p.Detali_Zakaza)
                    .HasForeignKey(d => d.Pizza_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detali_Zakaza_Pizza");

                entity.HasOne(d => d.Razmer_Pizza_)
                    .WithMany(p => p.Detali_Zakaza)
                    .HasForeignKey(d => d.Razmer_Pizza_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detali_Zakaza_Razmer_Pizza");
            });

            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.HasKey(e => e.Ingredinets_ID);

                entity.Property(e => e.Nazvanie_Ingredienta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.Pizza_ID);

                entity.Property(e => e.Nazvanie)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pizza_Ingredients>(entity =>
            {
                entity.HasKey(e => e.Pizza_Ingredients_ID);

                entity.HasOne(d => d.Ingredients_)
                    .WithMany(p => p.Pizza_Ingredients)
                    .HasForeignKey(d => d.Ingredients_ID)
                    .HasConstraintName("FK_Pizza_Ingredients_Ingredients");

                entity.HasOne(d => d.Pizza_)
                    .WithMany(p => p.Pizza_Ingredients)
                    .HasForeignKey(d => d.Pizza_ID)
                    .HasConstraintName("FK_Pizza_Ingredients_Pizza");
            });

            modelBuilder.Entity<Razmer_Pizza>(entity =>
            {
                entity.HasKey(e => e.Razmer_Pizza_ID);

                entity.Property(e => e.Razmer_Pizza1)
                    .IsRequired()
                    .HasColumnName("Razmer_Pizza")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zakaz>(entity =>
            {
                entity.HasKey(e => e.Zakaz_ID);

                entity.Property(e => e.Data_Zakaza).HasColumnType("date");

                entity.Property(e => e.Stoimost).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client_)
                    .WithMany(p => p.Zakaz)
                    .HasForeignKey(d => d.Client_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zakaz_Clients");

                entity.HasOne(d => d.Detali_Zakaza_)
                    .WithMany(p => p.Zakaz)
                    .HasForeignKey(d => d.Detali_Zakaza_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zakaz_Detali_Zakaza");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
