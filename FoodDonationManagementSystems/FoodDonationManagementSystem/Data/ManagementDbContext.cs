using FoodDonationManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Data
{
    public class ManagementDbContext:DbContext
    {
        public ManagementDbContext(DbContextOptions<ManagementDbContext> options) : base(options)
        {

        }
        public DbSet<Management> management { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Management>(entity =>
            {
                entity.Property(e => e.ManagementId).HasColumnName("ManagementId");
                entity.Property(e => e.ManagementName).HasColumnName("ManagementName");
                entity.Property(e => e.ManagementCity).HasColumnName("ManagementCity");
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
