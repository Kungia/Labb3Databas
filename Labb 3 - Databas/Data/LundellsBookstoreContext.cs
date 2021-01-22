using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Labb3
{
    public partial class LundellsBookstoreContext : DbContext
    {
        public LundellsBookstoreContext()
        {
        }

        public LundellsBookstoreContext(DbContextOptions<LundellsBookstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Butiker> Butikers { get; set; }
        public virtual DbSet<Böcker> Böckers { get; set; }
        public virtual DbSet<FörfattarBokJunc> FörfattarBokJuncs { get; set; }
        public virtual DbSet<Författare> Författares { get; set; }
        public virtual DbSet<Förlag> Förlags { get; set; }
        public virtual DbSet<Lagersaldo> Lagersaldos { get; set; }
        public virtual DbSet<Ordrar> Ordrars { get; set; }
        public virtual DbSet<Ordrarförlagtitel> Ordrarförlagtitels { get; set; }
        public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=LundellsBookstore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.HasKey(e => e.IdentityId)
                    .HasName("PK__Butiker__30667A2585A5FCF1");

                entity.ToTable("Butiker");

                entity.Property(e => e.IdentityId)
                    .ValueGeneratedNever()
                    .HasColumnName("IdentityID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Butiksnamn)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn13)
                    .HasName("PK__tmp_ms_x__3BF79E03714CB33F");

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn13)
                    .ValueGeneratedNever()
                    .HasColumnName("ISBN13");

                entity.Property(e => e.Språk)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FörfattarBokJunc>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Isbn13 })
                    .HasName("PK__tmp_ms_x__11AB95C623CD1EFA")
                    .IsClustered(false);

                entity.ToTable("FörfattarBokJunc");

                entity.HasIndex(e => new { e.Id, e.Isbn13 }, "PK_FörfattarBokJunc")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isbn13).HasColumnName("ISBN13");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.FörfattarBokJuncs)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FörfattarBok__ID__6EF57B66");

                entity.HasOne(d => d.Isbn13Navigation)
                    .WithMany(p => p.FörfattarBokJuncs)
                    .HasForeignKey(d => d.Isbn13)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Författar__ISBN1__6E01572D");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Förlag>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__tmp_ms_x__447D36EBA44A234B");

                entity.ToTable("Förlag");

                entity.Property(e => e.Isbn)
                    .ValueGeneratedNever()
                    .HasColumnName("ISBN");

                entity.Property(e => e.FörlagsId).HasColumnName("FörlagsID");

                entity.Property(e => e.Förlagsnamn)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IsbnNavigation)
                    .WithOne(p => p.Förlag)
                    .HasForeignKey<Förlag>(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Förlag__ISBN__1F98B2C1");
            });

            modelBuilder.Entity<Lagersaldo>(entity =>
            {
                entity.HasKey(e => new { e.Isbn, e.ButikId })
                    .HasName("PK__tmp_ms_x__FF20505495A11286");

                entity.ToTable("Lagersaldo");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.HasOne(d => d.Butik)
                    .WithMany(p => p.Lagersaldos)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lagersald__Butik__236943A5");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.Lagersaldos)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lagersaldo__ISBN__1EA48E88");
            });

            modelBuilder.Entity<Ordrar>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__tmp_ms_x__447D36EBF09D5D4E");

                entity.ToTable("Ordrar");

                entity.Property(e => e.Isbn)
                    .ValueGeneratedNever()
                    .HasColumnName("ISBN");

                entity.Property(e => e.Kund)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithOne(p => p.Ordrar)
                    .HasForeignKey<Ordrar>(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ordrar__ISBN__208CD6FA");
            });

            modelBuilder.Entity<Ordrarförlagtitel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ordrarförlagtitel");

                entity.Property(e => e.Bok)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Förlag)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
