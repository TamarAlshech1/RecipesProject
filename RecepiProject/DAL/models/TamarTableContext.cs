using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.models
{
    public partial class TamarTableContext : DbContext
    {
        public TamarTableContext()
        {
        }

        public TamarTableContext(DbContextOptions<TamarTableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EngrediensTable> EngrediensTables { get; set; } = null!;
        public virtual DbSet<EngrediensTableForRecepi> EngrediensTableForRecepis { get; set; } = null!;
        public virtual DbSet<RecepiTablebad> RecepiTablebads { get; set; } = null!;
        public virtual DbSet<UserTable> UserTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=kitotSrv\\sql;Database=TamarTable;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EngrediensTable>(entity =>
            {
                entity.HasKey(e => e.IdEngrediens);

                entity.ToTable("Engrediens_Table");

                entity.Property(e => e.IdEngrediens).HasColumnName("ID_ENGREDIENS");

                entity.Property(e => e.NameEngrediens)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME_ENGREDIENS");
            });

            modelBuilder.Entity<EngrediensTableForRecepi>(entity =>
            {
                entity.HasKey(e => e.IdForRrecepi);

                entity.ToTable("Engrediens_Table_For_Recepi");

                entity.Property(e => e.IdForRrecepi).HasColumnName("ID_FOR_RRECEPI");

                entity.Property(e => e.Count)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNT");

                entity.Property(e => e.IdEngrediens).HasColumnName("ID_ENGREDIENS");

                entity.Property(e => e.IdRecepi).HasColumnName("ID_RECEPI");

                entity.HasOne(d => d.IdEngrediensNavigation)
                    .WithMany(p => p.EngrediensTableForRecepis)
                    .HasForeignKey(d => d.IdEngrediens)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Engrediens_Table_For_Recepi_Engrediens_Table");

                entity.HasOne(d => d.IdRecepiNavigation)
                    .WithMany(p => p.EngrediensTableForRecepis)
                    .HasForeignKey(d => d.IdRecepi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Engrediens_Table_For_Recepi_Recepi_Tablebad");
            });

            modelBuilder.Entity<RecepiTablebad>(entity =>
            {
                entity.ToTable("Recepi_Tablebad");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IdUser).HasColumnName("ID_USER");

                entity.Property(e => e.Lavel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAVEL");

                entity.Property(e => e.Nummanot).HasColumnName("NUMMANOT");

                entity.Property(e => e.Oraot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORAOT");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.Recepiname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEPINAME");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.RecepiTablebads)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recepi_Tablebad_UserTable");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.ToTable("UserTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password).HasColumnName("PASSWORD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
