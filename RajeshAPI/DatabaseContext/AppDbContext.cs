using Microsoft.EntityFrameworkCore;
using RajeshAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
