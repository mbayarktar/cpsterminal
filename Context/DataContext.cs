using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Context;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public virtual DbSet<CwUsers> CwUsers { get; set; }
    public virtual DbSet<Cw000Sevkfis> Cw000SevkFis { get; set; }
    public virtual DbSet<Cw000Warehouse> Cw000Warehouses { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-3P2VV5I;Database=CPS_LARD;User=sa;Password=mb220216;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AS");

        modelBuilder.Entity<CwUsers>(entity =>
        {
            entity.ToTable("cw_users").HasKey(x=>x.UsId);
        });

        modelBuilder.Entity<Cw000Sevkfis>(entity =>
        {
            entity.ToTable("cw_000_sevkfis").HasKey(x=>x.SevkReferans);
        });

         modelBuilder.Entity<Cw000Warehouse>(entity =>
        {
            entity.ToTable("cw_000_warehouse").HasKey(x=>x.DepReferans);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
