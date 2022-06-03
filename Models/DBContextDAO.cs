using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BotAbrirSoftware.Models
{
    public partial class DBContextDAO : DbContext
    {
        public DBContextDAO()
        {
        }

        public DBContextDAO(DbContextOptions<DBContextDAO> options)
            : base(options)
        {
        }

        public virtual DbSet<Emulador> Emuladors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=Database\\\\banco.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emulador>(entity =>
            {
                entity.ToTable("emulador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comando).HasColumnName("comando");

                entity.Property(e => e.Evento).HasColumnName("evento");

                entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
