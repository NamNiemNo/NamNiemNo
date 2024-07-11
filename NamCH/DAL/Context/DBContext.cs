using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chunhan> Chunhans { get; set; }

    public virtual DbSet<Congty> Congties { get; set; }

    public virtual DbSet<Cuahang> Cuahangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Thucung> Thucungs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=namniemno\\sqlexpress;Initial Catalog=SOF205_FINAL_TEST;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chunhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUNHAN__3213E83FA3781856");
        });

        modelBuilder.Entity<Congty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONGTY__3213E83F90323552");
        });

        modelBuilder.Entity<Cuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUAHANG__3213E83F66D78A0A");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Cuahangs).HasConstraintName("FKCH_TT");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3213E83FB6618A88");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHANVIEN__3213E83FFAE91CC0");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Nhanviens).HasConstraintName("FKNV_CT");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83F3B703EC8");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams).HasConstraintName("FK_SP_NCC");
        });

        modelBuilder.Entity<Thucung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THUCUNG__3213E83FDB1277F5");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Thucungs).HasConstraintName("FK_TC_CN");
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRUNGTAM__3213E83F58E58989");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
