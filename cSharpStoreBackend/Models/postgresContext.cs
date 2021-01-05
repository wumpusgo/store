using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace cSharpStoreBackend.Models
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseBill> PurchaseBills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.IdBill)
                    .HasName("bill_pkey");

                entity.ToTable("bill");

                entity.Property(e => e.IdBill)
                    .ValueGeneratedNever()
                    .HasColumnName("id_bill");

                entity.Property(e => e.Product)
                    .HasMaxLength(20)
                    .HasColumnName("product");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("fk_product_bill");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("category_pkey");

                entity.ToTable("category");

                entity.Property(e => e.IdCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("id_category");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("product_pkey");

                entity.ToTable("product");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UnitCost).HasColumnName("unit_cost");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_product_category_id");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.IdPurchase)
                    .HasName("purchase_pkey");

                entity.ToTable("purchase");

                entity.Property(e => e.IdPurchase)
                    .ValueGeneratedNever()
                    .HasColumnName("id_purchase");
            });

            modelBuilder.Entity<PurchaseBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("purchase_bill");

                entity.HasIndex(e => e.BillIdBill, "uk_c0hcq4od797lib8canktfxr6h")
                    .IsUnique();

                entity.Property(e => e.BillIdBill).HasColumnName("bill_id_bill");

                entity.Property(e => e.PurchaseIdPurchase).HasColumnName("purchase_id_purchase");

                entity.HasOne(d => d.BillIdBillNavigation)
                    .WithOne()
                    .HasForeignKey<PurchaseBill>(d => d.BillIdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk78oy2ut49d0d66b6v120gf7g0");

                entity.HasOne(d => d.PurchaseIdPurchaseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PurchaseIdPurchase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkmit8k3liis5uy16ln953fcp2d");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
