﻿using System;
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

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CaseStatus> CaseStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:east-cheap-server.database.windows.net,1433;Initial Catalog=caseStatusDB;Persist Security Info=False;User ID=somych;Password=905905Centrino;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.ReceiptNumber).HasName("PK__Cases__AE5529A50492247F");

            entity.ToTable("Cases", "CaseStatusApp");

            entity.Property(e => e.ReceiptNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("receiptNumber");
            entity.Property(e => e.FormType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("formType");
            entity.Property(e => e.SubmittedDate)
                .HasColumnType("datetime")
                .HasColumnName("submittedDate");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Cases)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Cases__userId__160F4887");
        });

        modelBuilder.Entity<CaseStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__CaseStat__36257A18F98327C3");

            entity.ToTable("CaseStatus", "CaseStatusApp");

            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.CurrentCaseStatusDesc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("currentCaseStatusDesc");
            entity.Property(e => e.CurrentaseStatusText)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("currentaseStatusText");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReceiptNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("receiptNumber");

            entity.HasOne(d => d.ReceiptNumberNavigation).WithMany(p => p.CaseStatuses)
                .HasForeignKey(d => d.ReceiptNumber)
                .HasConstraintName("FK__CaseStatu__recei__18EBB532");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF6AAC27EF");

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