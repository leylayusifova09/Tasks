using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pageination.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Qrup> Qrups { get; set; } = null!;
        public virtual DbSet<Telebe> Telebes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7OTSFF0;Database=Test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Qrup>(entity =>
            {
                entity.ToTable("Qrup");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Telebe>(entity =>
            {
                entity.ToTable("Telebe");

                entity.Property(e => e.Ad).HasMaxLength(10);

                entity.Property(e => e.QrupId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Qrup_id");

                entity.HasOne(d => d.Qrup)
                    .WithMany(p => p.Telebes)
                    .HasForeignKey(d => d.QrupId)
                    .HasConstraintName("FK__Telebe__Qrup_id__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
