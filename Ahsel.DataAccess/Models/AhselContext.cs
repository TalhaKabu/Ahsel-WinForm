using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ahsel.DataAccess.Models;

public partial class AhselContext : DbContext
{
    public AhselContext()
    {
    }

    public AhselContext(DbContextOptions<AhselContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Description> Descriptions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\LocalDB;User ID=Talha;Password=825425228t;Database=Ahsel;Trusted_Connection=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("db_accessadmin");

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Clients", "dbo");
            entity.HasKey(c => c.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payments", "dbo");
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Projects", "dbo");
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Description>(entity =>
        {
            entity.ToTable("Descriptions", "dbo");
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
