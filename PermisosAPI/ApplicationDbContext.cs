using PermisosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace PermisosAPI;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)

{

    public virtual DbSet<Permiso> Permisos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.Property(e => e.Memo).HasMaxLength(20);
            entity.Property(e => e.Notas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Situacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudId).HasMaxLength(20);
            entity.Property(e => e.TipoDia)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

    }

}
