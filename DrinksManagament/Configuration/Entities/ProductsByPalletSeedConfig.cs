using DrinksManagament.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class ProductsByPalletSeedConfig : IEntityTypeConfiguration<ProductsByPallet>
    {
        public void Configure(EntityTypeBuilder<ProductsByPallet> builder)
        {
            builder.HasData(
                new ProductsByPallet
                {
                    Id = 1,
                    ProductId = 1,
                    PalletId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Quantity = 15,
                }
                );
        }
    }
}
