using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Performance.Domain.Models;

namespace Performance.Infrastructure.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Domain Entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // keep Identity config

            // ============================
            // Many-to-Many: Driver ↔ Vehicle
            // ============================
            builder.Entity<Driver>()
                .HasMany(d => d.Vehicles)
                .WithMany(v => v.Drivers)
                .UsingEntity(j => j.ToTable("DriverVehicles"));

            // ============================
            // Many-to-Many: Factory ↔ Material
            // ============================
            builder.Entity<Factory>()
                .HasMany(f => f.Materials)
                .WithMany(m => m.Factories)
                .UsingEntity(j => j.ToTable("FactoryMaterials"));

            // ============================
            // Many-to-Many: Supplier ↔ Factory
            // ============================
            builder.Entity<Supplier>()
                .HasMany(s => s.Factories)
                .WithMany(f => f.Suppliers)
                .UsingEntity(j => j.ToTable("SupplierFactories"));

            builder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
