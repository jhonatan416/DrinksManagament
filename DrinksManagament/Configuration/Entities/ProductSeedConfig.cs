using DrinksManagament.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class ProductSeedConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                  new Product()
                  {
                      Id = 1,
                      Name = "Coca Cola",
                      Description = "Coca Cola 350 ML",
                      PriceForOne = 1500,
                      PriceForStock = 1200,
                      DateCreated = DateTime.Now,
                      DateModified = DateTime.Now,
                      ProductTypeId = 1,
                  }
              );
        }
    }
}
