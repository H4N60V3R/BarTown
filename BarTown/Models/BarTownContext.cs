using System;
using BarTown.Models.ProcedureResponseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BarTown.Models.Entities
{
    public partial class BarTownContext : DbContext
    {
        public BarTownContext()
        {
        }

        public BarTownContext(DbContextOptions<BarTownContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblConfig> TblConfig { get; set; }
        public virtual DbSet<TblLocation> TblLocation { get; set; }
        public virtual DbSet<TblShippingCost> TblShippingCost { get; set; }
        public virtual DbSet<TblTruckService> TblTruckService { get; set; }
        public virtual DbSet<TblTruckType> TblTruckType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblConfig>(entity =>
            {
                entity.HasKey(e => e.PkConfig);

                entity.ToTable("tblConfig");

                entity.Property(e => e.PkConfig).HasColumnName("pkConfig");

                entity.Property(e => e.ConfigDesc1).HasMaxLength(1000);

                entity.Property(e => e.ConfigDesc2).HasMaxLength(1000);

                entity.Property(e => e.FkPosition).HasColumnName("fkPosition");
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.HasKey(e => e.PkLocation);

                entity.ToTable("tblLocation");

                entity.HasIndex(e => e.LocationName)
                    .HasName("IX_tblLocation")
                    .IsUnique();

                entity.Property(e => e.PkLocation).HasColumnName("pkLocation");

                entity.Property(e => e.FkLocationType)
                    .HasColumnName("fkLocationType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FkTehranRegion).HasColumnName("fkTehranRegion");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);
            });

            modelBuilder.Entity<TblShippingCost>(entity =>
            {
                entity.HasKey(e => e.PkShippingCost);

                entity.ToTable("tblShippingCost");

                entity.Property(e => e.PkShippingCost).HasColumnName("pkShippingCost");

                entity.Property(e => e.FkDestinationLocation).HasColumnName("fkDestinationLocation");

                entity.Property(e => e.FkOriginLocation).HasColumnName("fkOriginLocation");

                entity.Property(e => e.FkTruckType).HasColumnName("fkTruckType");

                entity.Property(e => e.ShippingCostDesc).HasMaxLength(500);
            });

            modelBuilder.Entity<TblTruckService>(entity =>
            {
                entity.HasKey(e => e.PkTruckService);

                entity.ToTable("tblTruckService");

                entity.Property(e => e.PkTruckService).HasColumnName("pkTruckService");

                entity.Property(e => e.FkTruckType).HasColumnName("fkTruckType");

                entity.Property(e => e.TruckServiceDesc).HasMaxLength(500);
            });

            modelBuilder.Entity<TblTruckType>(entity =>
            {
                entity.HasKey(e => e.PkTruckType);

                entity.ToTable("tblTruckType");

                entity.Property(e => e.PkTruckType)
                    .HasColumnName("pkTruckType")
                    .ValueGeneratedNever();

                entity.Property(e => e.TruckTypeDesc).HasMaxLength(500);

                entity.Property(e => e.TruckTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpSelShippingCost>().HasNoKey()
                .ToView(null);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
