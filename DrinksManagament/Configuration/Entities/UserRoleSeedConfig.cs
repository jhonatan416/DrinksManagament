using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>()
                    {
                        UserId = "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                        RoleId = "d47e33eb-7f01-455b-9f83-fd5cdccc7884",
                    }, new IdentityUserRole<string>()
                    {
                        UserId = "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                        RoleId = "a78e54etb-7f01-455b-9f83-fd8cdccc8549",
                    }
                );
        }
    }
}
