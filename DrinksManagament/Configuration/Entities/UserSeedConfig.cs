using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrinksManagament.Configuration.Entities
{
    public class UserSeedConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                    new IdentityUser()
                    {
                        Id = "d47e33eb-7f01-455b-9f76-fd6cdccc1284",
                        UserName = "admin@localhost.com",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    },
                    new IdentityUser()
                    {
                        Id = "d47e33eb-7f01-455b-9f76-fd6cdccc8897",
                        UserName = "user@localhost.com",
                        NormalizedUserName = "USER@LOCALHOST.COM",
                        Email = "user@localhost.com",
                        NormalizedEmail = "USER@LOCALHOST.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    }
                );
        }
    }
}
