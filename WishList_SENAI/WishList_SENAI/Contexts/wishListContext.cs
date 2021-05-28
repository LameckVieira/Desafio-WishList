using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WishList_SENAI.Domains;

#nullable disable

namespace WishList_SENAI.Contexts
{
    public partial class wishListContext : DbContext
    {
        public wishListContext()
        {
        }

        public wishListContext(DbContextOptions<wishListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Desejo> Desejos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5SR3EMT; initial catalog=WishList_SENAI; user ID=sa; pwd=6228;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Desejo>(entity =>
            {
                entity.HasKey(e => e.IdDesejo)
                    .HasName("PK__Desejos__5DB1341F8F56F4F1");

                entity.Property(e => e.IdDesejo).HasColumnName("idDesejo");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DescricaoDesejo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Desejos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Desejos__idUsuar__38996AB5");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__645723A69BEF05B0");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
