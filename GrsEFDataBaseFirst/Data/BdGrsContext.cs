using System;
using System.Collections.Generic;
using GrsEFDataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace GrsEFDataBaseFirst.Data;

public partial class BdGrsContext : DbContext
{
    public BdGrsContext()
    {
    }
    public BdGrsContext(DbContextOptions<BdGrsContext> options)
    : base(options)
    {
    }
    public virtual DbSet<Albergue> Albergues { get; set; }
    public virtual DbSet<Cliente> Clientes { get; set; }
    public virtual DbSet<Etapa> Etapas { get; set; }
    public virtual DbSet<Gr> Grs { get; set; }
    public virtual DbSet<Ocupacione> Ocupaciones { get; set; }
    public virtual DbSet<Zona> Zonas { get; set; }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Albergue>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(10);
            entity.Property(e => e.IdZona).HasMaxLength(5);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.IdZonaNavigation).WithMany(p => p.Albergues)
                .HasForeignKey(d => d.IdZona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Albergues_Zonas");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Dni);

            entity.Property(e => e.Dni).HasMaxLength(9);
            entity.Property(e => e.Nombre).HasMaxLength(20);
            entity.Property(e => e.Telefono).HasMaxLength(9);
        });

        modelBuilder.Entity<Etapa>(entity =>
        {
            entity.HasKey(e => new { e.IdGr, e.NumEtapa });

            entity.Property(e => e.IdGr).HasMaxLength(5);
            entity.Property(e => e.IdZona).HasMaxLength(5);

            entity.HasOne(d => d.IdGrNavigation).WithMany(p => p.Etapas)
                .HasForeignKey(d => d.IdGr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Etapas_Grs");

            entity.HasOne(d => d.IdZonaNavigation).WithMany(p => p.Etapas)
                .HasForeignKey(d => d.IdZona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Etapas_Zonas");
        });

        modelBuilder.Entity<Gr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gr");

            entity.Property(e => e.Id).HasMaxLength(5);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Ocupacione>(entity =>
        {
            entity.HasKey(e => new { e.Dni, e.IdAlbergue }).HasName("PK_Ocupaciones_1");

            entity.Property(e => e.Dni).HasMaxLength(9);
            entity.Property(e => e.IdAlbergue).HasMaxLength(10);

            entity.HasOne(d => d.DniNavigation).WithMany(p => p.Ocupaciones)
                .HasForeignKey(d => d.Dni)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ocupaciones_Clientes");

            entity.HasOne(d => d.IdAlbergueNavigation).WithMany(p => p.Ocupaciones)
                .HasForeignKey(d => d.IdAlbergue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ocupaciones_Albergues");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(5);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
