using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infra.EntitiesConfiguration
{
    public static class EntitiesConfiguration
    {
        public static void ApplyConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alquiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tAlquiler");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("fechaEntrada")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("fechaSalida")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCliente).HasColumnName("fkCliente");

                entity.Property(e => e.FkHabitacion).HasColumnName("fkHabitacion");

                entity.Property(e => e.FkVendedor)
                    .HasColumnName("fkVendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdAlquiler)
                    .HasColumnName("idAlquiler")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("text");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.HasOne(d => d.FkClienteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkCliente)
                    .HasConstraintName("FK__tAlquiler__fkCli__52593CB8");

                entity.HasOne(d => d.FkHabitacionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkHabitacion)
                    .HasConstraintName("FK__tAlquiler__fkHab__5165187F");

                entity.HasOne(d => d.FkVendedorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkVendedor)
                    .HasConstraintName("FK__tAlquiler__fkVen__534D60F1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__tCliente__885457EEAD59D57A");

                entity.ToTable("tCliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.LugarNacimiento)
                    .HasColumnName("lugarNacimiento")
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("text");

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.HasKey(e => e.IdHabitacion)
                    .HasName("PK__tHabitac__8BBBF90174B6386F");

                entity.ToTable("tHabitacion");

                entity.Property(e => e.IdHabitacion).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.FkTipo)
                    .HasColumnName("fkTipo")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroCamas).HasColumnName("numeroCamas");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("text");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                entity.HasOne(d => d.FkTipoNavigation)
                    .WithMany(p => p.THabitacion)
                    .HasForeignKey(d => d.FkTipo)
                    .HasConstraintName("FK__tHabitaci__fkTip__4F7CD00D");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__tTipo__BDD0DFE19430C468");

                entity.ToTable("tTipo");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("idTipo")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PK__tVendedo__A6693F93EE968BCC");

                entity.ToTable("tVendedor");

                entity.Property(e => e.IdVendedor)
                    .HasColumnName("idVendedor")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("text");

                entity.Property(e => e.Sueldo)
                    .HasColumnName("sueldo")
                    .HasColumnType("money");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
