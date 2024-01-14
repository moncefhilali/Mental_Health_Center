using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Mental_Health_CenterContext : DbContext
    {
        public Mental_Health_CenterContext()
        {
        }

        public Mental_Health_CenterContext(DbContextOptions<Mental_Health_CenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Clinic> Clinic { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Treatment> Treatment { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3SA4E25\\SQLEXPRESS;Initial Catalog=Mental_Health_Center;Persist Security Info=True;User ID=sa; Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Link)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdImageNavigation)
                    .WithMany(p => p.Clinic)
                    .HasForeignKey(d => d.IdImage)
                    .HasConstraintName("fk_Image_Clinic");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Clinic)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("fk_Type_Clinic");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdImageNavigation)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.IdImage)
                    .HasConstraintName("fk_Image_Doctor");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_Category_Service");

                entity.HasOne(d => d.IdImageNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.IdImage)
                    .HasConstraintName("fk_Image_Service");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Body)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.Topic)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDoctorNavigation)
                    .WithMany(p => p.Treatment)
                    .HasForeignKey(d => d.IdDoctor)
                    .HasConstraintName("fk_Doctor_Treatment");

                entity.HasOne(d => d.IdImageNavigation)
                    .WithMany(p => p.Treatment)
                    .HasForeignKey(d => d.IdImage)
                    .HasConstraintName("fk_Image_Treatment");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
