using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.Models
{
    public class CarLibContext : DbContext
    {
        public CarLibContext(DbContextOptions<CarLibContext> options) : base(options)
        { 
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>().ToTable("Model");
            modelBuilder.Entity<Brand>().ToTable("Brand");
        }
    }
}
