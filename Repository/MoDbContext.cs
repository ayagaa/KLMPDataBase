using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KLMP.DataAccess.Repository.Models;

namespace KLMP.DataAccess.Repository
{
    public partial class MoDbContext : DbContext
    {
        public MoDbContext()
        {
        }

        public MoDbContext(DbContextOptions<MoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCounty> TblCounties { get; set; } = null!;
        public virtual DbSet<TblFacilityActivityPeriod> TblFacilityActivityPeriods { get; set; } = null!;
        public virtual DbSet<TblFacilityAmenity> TblFacilityAmenities { get; set; } = null!;
        public virtual DbSet<TblFacilityContactPerson> TblFacilityContactPeople { get; set; } = null!;
        public virtual DbSet<TblFacilityDescription> TblFacilityDescriptions { get; set; } = null!;
        public virtual DbSet<TblFacilityMetric> TblFacilityMetrics { get; set; } = null!;
        public virtual DbSet<TblFacilityProfile> TblFacilityProfiles { get; set; } = null!;
        public virtual DbSet<TblFacilityValueChain> TblFacilityValueChains { get; set; } = null!;
        public virtual DbSet<TblSubCounty> TblSubCounties { get; set; } = null!;
        public virtual DbSet<TblValueChain> TblValueChains { get; set; } = null!;
        public virtual DbSet<TblWard> TblWards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS2019;Initial Catalog=KLMP_Stagingv1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCounty>(entity =>
            {
                entity.Property(e => e.CountyId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblFacilityActivityPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodEntryId)
                    .HasName("PK_tblSlaughterActivityPeriod");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityActivityPeriods)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_tblSlaughterActivityPeriod_tblFacilityProfile");
            });

            modelBuilder.Entity<TblFacilityAmenity>(entity =>
            {
                entity.HasKey(e => e.AmenityEntryId)
                    .HasName("PK_tblSlaughterFacility");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityAmenities)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFacilityAmenity_tblFacilityProfile");
            });

            modelBuilder.Entity<TblFacilityContactPerson>(entity =>
            {
                entity.Property(e => e.ContactEntryId).ValueGeneratedNever();

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityContactPeople)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_tblFacilityContactPerson_tblFacilityProfile");
            });

            modelBuilder.Entity<TblFacilityDescription>(entity =>
            {
                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityDescriptions)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_tblFacilityDescription_tblFacilityProfile");
            });

            modelBuilder.Entity<TblFacilityMetric>(entity =>
            {
                entity.Property(e => e.YearOfMeasure).HasDefaultValueSql("((1900))");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityMetrics)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFacilityMetric_tblFacilityProfile");
            });

            modelBuilder.Entity<TblFacilityProfile>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("PK_tblFacility");

                entity.Property(e => e.Altitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.Longitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precision).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.TblFacilityProfiles)
                    .HasForeignKey(d => d.WardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFacilityProfile_tblWard");
            });

            modelBuilder.Entity<TblFacilityValueChain>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .HasName("PK_linkFacilityValueChain");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityValueChains)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_tblFacilityValueChain_tblFacilityProfile");

                entity.HasOne(d => d.ValueChain)
                    .WithMany(p => p.TblFacilityValueChains)
                    .HasForeignKey(d => d.ValueChainId)
                    .HasConstraintName("FK_tblFacilityValueChain_tblValueChain");
            });

            modelBuilder.Entity<TblSubCounty>(entity =>
            {
                entity.Property(e => e.SubcountyId).ValueGeneratedNever();

                entity.HasOne(d => d.County)
                    .WithMany(p => p.TblSubCounties)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSubCounty_tblCounty");
            });

            modelBuilder.Entity<TblValueChain>(entity =>
            {
                entity.HasKey(e => e.ValueChainId)
                    .HasName("PK_tblFacilityValueChain");
            });

            modelBuilder.Entity<TblWard>(entity =>
            {
                entity.Property(e => e.WardId).ValueGeneratedNever();

                entity.HasOne(d => d.County)
                    .WithMany(p => p.TblWards)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblWard_tblCounty");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
