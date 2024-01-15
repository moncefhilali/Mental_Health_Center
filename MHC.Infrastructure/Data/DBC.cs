using Microsoft.EntityFrameworkCore;
using MHC.Domain.Entities;

namespace MHC.Infrastructure.Data;

public partial class DBC : DbContext
{
    public DBC()
    {
    }

    public DBC(DbContextOptions<DBC> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<OurService> Services { get; set; }

    public virtual DbSet<Treatment> Treatments { get; set; }

    public virtual DbSet<ClinicType> ClinicTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-3SA4E25\\SQLEXPRESS;Initial Catalog=Mental_Health_Center;TrustServerCertificate=True;User ID=sa;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Category");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Clinic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Clinic");

            entity.ToTable("Clinic");

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

            entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.Clinics)
                .HasForeignKey(d => d.IdImage)
                .HasConstraintName("fk_Image_Clinic");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Clinics)
                .HasForeignKey(d => d.IdType)
                .HasConstraintName("fk_Type_Clinic");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Doctor");

            entity.ToTable("Doctor");

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

            entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.IdImage)
                .HasConstraintName("fk_Image_Doctor");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Image");

            entity.ToTable("Image");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Path)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OurService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Service");

            entity.ToTable("OurService");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("fk_Category_Service");

            entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.IdImage)
                .HasConstraintName("fk_Image_Service");
        });

        modelBuilder.Entity<Treatment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Treatment");

            entity.ToTable("Treatment");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Body)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("date");
            entity.Property(e => e.Topic)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDoctorNavigation).WithMany(p => p.Treatments)
                .HasForeignKey(d => d.IdDoctor)
                .HasConstraintName("fk_Doctor_Treatment");

            entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.Treatments)
                .HasForeignKey(d => d.IdImage)
                .HasConstraintName("fk_Image_Treatment");
        });

        modelBuilder.Entity<ClinicType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Type");

            entity.ToTable("ClinicType");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
