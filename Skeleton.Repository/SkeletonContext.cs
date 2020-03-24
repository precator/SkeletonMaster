using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Skeleton.Models;

namespace Skeleton.Repository
{
    public partial class SkeletonContext : DbContext
    {
        public SkeletonContext()
        {
        }

        public SkeletonContext(DbContextOptions<SkeletonContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<BuySignals> BuySignals { get; set; }
        public virtual DbSet<BuyTargetsBasedOnHistorical> BuyTargetsBasedOnHistorical { get; set; }
        public virtual DbSet<Dbimport> Dbimport { get; set; }
        public virtual DbSet<ManufacturingProductsCosts> ManufacturingProductsCosts { get; set; }
        public virtual DbSet<MyInfo> MyInfo { get; set; }
        public virtual DbSet<PriceMonitors> PriceMonitors { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<PricesArchive> PricesArchive { get; set; }
        public virtual DbSet<ProductManufacturing> ProductManufacturing { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RetailInfo> RetailInfo { get; set; }
        public virtual DbSet<_10percentDiscounts> _10percentDiscounts { get; set; }
        public virtual DbSet<_15percentDiscounts> _15percentDiscounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buildings>(entity =>
            {
                entity.ToTable("buildings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModifedDate)
                    .HasColumnName("modifedDate")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wages).HasColumnName("wages");
            });

            modelBuilder.Entity<BuySignals>(entity =>
            {
                entity.ToTable("buySignals");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PercentDiscount).HasColumnName("percentDiscount");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            modelBuilder.Entity<BuyTargetsBasedOnHistorical>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BuyTargetsBasedOnHistorical");

                entity.Property(e => e.AveragePrice).HasColumnName("Average Price");

                entity.Property(e => e.CurrentPrice).HasColumnName("Current Price");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            modelBuilder.Entity<Dbimport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbimport");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("productID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufacturingProductsCosts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ManufacturingProductsCosts");

                entity.Property(e => e.Buildingwages).HasColumnName("buildingwages");

                entity.Property(e => e.InputFiveId).HasColumnName("inputFiveID");

                entity.Property(e => e.InputFiveQty).HasColumnName("inputFiveQty");

                entity.Property(e => e.InputFourId).HasColumnName("inputFourID");

                entity.Property(e => e.InputFourQty).HasColumnName("inputFourQty");

                entity.Property(e => e.InputOneId).HasColumnName("inputOneID");

                entity.Property(e => e.InputOneQty).HasColumnName("inputOneQty");

                entity.Property(e => e.InputThreeId).HasColumnName("inputThreeID");

                entity.Property(e => e.InputTwoId).HasColumnName("inputTwoID");

                entity.Property(e => e.InputTwoQty).HasColumnName("inputTwoQty");

                entity.Property(e => e.Producedat)
                    .IsRequired()
                    .HasColumnName("producedat")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RetailPrice).HasColumnName("retailPrice");

                entity.Property(e => e.UnitsPerHour).HasColumnName("unitsPerHour");
            });

            modelBuilder.Entity<MyInfo>(entity =>
            {
                entity.ToTable("myInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminOverhead).HasColumnName("adminOverhead");
            });

            modelBuilder.Entity<PriceMonitors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PriceLowerThan).HasColumnName("priceLowerThan");

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            modelBuilder.Entity<Prices>(entity =>
            {
                entity.ToTable("prices");

                entity.HasIndex(e => new { e.Price, e.ProductId })
                    .HasName("nci_wi_prices_40ED8801DA070149A978ED117C615498");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prices_products");
            });

            modelBuilder.Entity<PricesArchive>(entity =>
            {
                entity.ToTable("prices_archive");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            modelBuilder.Entity<ProductManufacturing>(entity =>
            {
                entity.ToTable("productManufacturing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InputFiveId).HasColumnName("inputFiveID");

                entity.Property(e => e.InputFiveQty).HasColumnName("inputFiveQty");

                entity.Property(e => e.InputFourId).HasColumnName("inputFourID");

                entity.Property(e => e.InputFourQty).HasColumnName("inputFourQty");

                entity.Property(e => e.InputOneId).HasColumnName("inputOneID");

                entity.Property(e => e.InputOneQty).HasColumnName("inputOneQty");

                entity.Property(e => e.InputThreeId).HasColumnName("inputThreeID");

                entity.Property(e => e.InputTwoId).HasColumnName("inputTwoID");

                entity.Property(e => e.InputTwoQty).HasColumnName("inputTwoQty");

                entity.Property(e => e.ProducedAt).HasColumnName("producedAt");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.RetailPrice).HasColumnName("retailPrice");

                entity.Property(e => e.UnitsPerHour).HasColumnName("unitsPerHour");
                entity.HasOne(d => d.ProducedAtNavigation)
                  .WithMany(p => p.ProductManufacturing)
                  .HasForeignKey(d => d.ProducedAt)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_productManufacturing_buildings");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .HasColumnName("productID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvgPrice).HasColumnName("avgPrice");

                entity.Property(e => e.EnableAlerts).HasColumnName("enableAlerts");

                entity.Property(e => e.HighPrice).HasColumnName("highPrice");

                entity.Property(e => e.LowPrice).HasColumnName("lowPrice");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RetailInfo>(entity =>
            {
                entity.ToTable("retailInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.RetailPrice).HasColumnName("retailPrice");

                entity.Property(e => e.UnitsSoldPerHour).HasColumnName("unitsSoldPerHour");
            });

            modelBuilder.Entity<_10percentDiscounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("10PercentDiscounts");

                entity.Property(e => e.AvgPrice).HasColumnName("avgPrice");

                entity.Property(e => e.HighPrice).HasColumnName("highPrice");

                entity.Property(e => e.LowPrice).HasColumnName("lowPrice");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            modelBuilder.Entity<_15percentDiscounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("15PercentDiscounts");

                entity.Property(e => e.AvgPrice).HasColumnName("avgPrice");

                entity.Property(e => e.HighPrice).HasColumnName("highPrice");

                entity.Property(e => e.LowPrice).HasColumnName("lowPrice");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("productID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
