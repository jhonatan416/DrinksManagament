using DrinksManagament.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class ProductTypeSeedConfig : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasData(
                    new ProductType()
                    {
                        Id = 1,
                        Name = "Gaseosas",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    }, new ProductType()
                    {
                        Id = 2,
                        Name = "Refrescos",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    }
                );
        }
    }
}
