using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cancha.Models
{
    public partial class UsersContext : DbContext
    {
        public UsersContext()
        {
        }

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CanchaFutbol> CanchaFutbols { get; set; } = null!;
        public virtual DbSet<CanchaVoleibol> CanchaVoleibols { get; set; } = null!;
        public virtual DbSet<Ciudad> Ciudads { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
        public virtual DbSet<Sede> Sedes { get; set; } = null!;
        public virtual DbSet<Sexo> Sexos { get; set; } = null!;
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("\nData Source=DESKTOP-6AHB6Q3;Initial Catalog=Canchas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CanchaFutbol>(entity =>
            {
                entity.HasKey(e => e.IdCanchaFut)
                    .HasName("PK__CanchaFu__7E4E8F545200826B");

                entity.ToTable("CanchaFutbol");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.NombreCancha)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TamanoCancha)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CanchaVoleibol>(entity =>
            {
                entity.HasKey(e => e.IdCanchaVolei)
                    .HasName("PK__CanchaVo__8D3A13B359C3872A");

                entity.ToTable("CanchaVoleibol");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.NombreCancha)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TamanoCancha)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PK__Ciudad__D4D3CCB00523DAC7");

                entity.ToTable("Ciudad");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresa__5EF4033EF6301D60");

                entity.ToTable("Empresa");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nit)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Estado");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Disponible)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mantenimiento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ocupado)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCanchaFutNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCanchaFut)
                    .HasConstraintName("fk_Estado_CanchaFutbol");

                entity.HasOne(d => d.IdCanchaVoleiNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCanchaVolei)
                    .HasConstraintName("fk_Estado_CanchaVoleibol");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reserva__0E49C69D55F8F254");

                entity.ToTable("Reserva");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.HasOne(d => d.IdCanchaFutNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdCanchaFut)
                    .HasConstraintName("fk_CanchaFutbol_Reserva");

                entity.HasOne(d => d.IdCanchaVoleiNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdCanchaVolei)
                    .HasConstraintName("fk_CanchaVoleibol_Reserva");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("fk_Sede_Reserva");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("fk_Usuario_Reserva");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.IdSede)
                    .HasName("PK__Sede__A7780DFFA65312C5");

                entity.ToTable("Sede");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Norte)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sur)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("fk_Ciudad_Sede");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo)
                    .HasName("PK__Sexo__A7739FA25258EFA9");

                entity.ToTable("Sexo");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Femenino)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Masculino)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Sexos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("fk_Usuario_Sexo");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__CA04062BB5E4AC7C");

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TipoUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("fk_TipoUsuario_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97D49C9DDE");

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
