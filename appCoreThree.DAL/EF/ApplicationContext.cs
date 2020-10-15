using appCoreThree.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<MasterRegion> MasterRegions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MasterRegion>()
                .HasKey(t => new { t.MasterId , t.RegionId});

            modelBuilder.Entity<MasterRegion>()
                .HasOne(m => m.Master)
                .WithMany(m => m.MasterRegions)
                .HasForeignKey(m => m.MasterId);

            modelBuilder.Entity<MasterRegion>()
                .HasOne(m => m.Region)
                .WithMany(m => m.MasterRegions)
                .HasForeignKey(m => m.RegionId);
        }
    }
}
