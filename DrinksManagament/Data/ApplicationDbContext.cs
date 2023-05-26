using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DrinksManagament.Models;
using System.Reflection.Emit;
using DrinksManagament.Configuration.Entities;

namespace DrinksManagament.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Pallet> Pallets{ get; set; }
        public DbSet<ProductsByPallet> ProductsByPallets{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>
                (p =>
                {
                    p.Property(pr => pr.PriceForOne).HasColumnType("decimal(8,2)");
                    p.Property(pr => pr.PriceForStock).HasColumnType("decimal(8,2)");
                });

            builder.ApplyConfiguration(new ProductSeedConfig());
            builder.ApplyConfiguration(new ProductTypeSeedConfig());
            builder.ApplyConfiguration(new PalletSeedConfig());
            builder.ApplyConfiguration(new ProductsByPalletSeedConfig());
            builder.ApplyConfiguration(new UserSeedConfig());
            builder.ApplyConfiguration(new RoleSeedConfig());
            builder.ApplyConfiguration(new UserRoleSeedConfig());
        }
    }
}