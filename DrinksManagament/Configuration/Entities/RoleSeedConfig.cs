using DrinksManagament.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole()
                {
                    Id = "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole()
                {
                    Id = "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
                );
        }
    }
}
