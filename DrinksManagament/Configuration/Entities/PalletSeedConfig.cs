using DrinksManagament.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class PalletSeedConfig : IEntityTypeConfiguration<Pallet>
    {
        public void Configure(EntityTypeBuilder<Pallet> builder)
        {
            builder.HasData(
                new Pallet
                {
                    Id = 1,
                    PositionCount = 50,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                },
                new Pallet{
                    Id = 2,
                    PositionCount = 20,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                }
                );
        }
    }
}
