using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CaseStatusTrackerAPI;

public partial class CaseStatusDbContext : DbContext
{
    public CaseStatusDbContext()
    {
    }

    public CaseStatusDbContext(DbContextOptions<CaseStatusDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaseNumber> CaseNumbers { get; set; }

    public virtual DbSet<CaseStatus> CaseStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:east-cheap-server.database.windows.net,1433;Initial Catalog=caseStatusDB;Persist Security Info=False;User ID=somych;Password=905905Centrino;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaseNumber>(entity =>
        {
            entity.HasKey(e => e.CaseId).HasName("PK__CaseNumb__956FA6C926E9A326");

            entity.ToTable("CaseNumber", "CaseStatusApp");

            entity.Property(e => e.CaseId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("caseId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.CaseNumbers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__CaseNumbe__userI__5EBF139D");
        });

        modelBuilder.Entity<CaseStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__CaseStat__36257A181670E0C6");

            entity.ToTable("CaseStatus", "CaseStatusApp");

            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.CaseId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("caseId");
            entity.Property(e => e.CaseStatus1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("caseStatus");

            entity.HasOne(d => d.Case).WithMany(p => p.CaseStatuses)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK__CaseStatu__caseI__619B8048");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF71ABF484");

            entity.ToTable("Users", "CaseStatusApp");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .HasColumnName("email");
            entity.Property(e => e.UserName)
                .HasMaxLength(32)
                .HasColumnName("userName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
