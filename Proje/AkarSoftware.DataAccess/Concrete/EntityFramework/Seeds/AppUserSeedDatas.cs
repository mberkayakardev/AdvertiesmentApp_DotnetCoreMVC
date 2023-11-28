using AkarSoftware.Core.Entities.Concrete;
using AkarSoftware.Core.Utilities.Security.HashHelper;
using AkarSoftware.Core.Utilities.TypeConversation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Seeds
{
    public class AppUserSeedDatas : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(

                new AppUser
                {
                    Id = 1,
                    IsActive = true,
                    UserName = StringConversation.NormalizeUpperCase("berkay"),
                    FirstName = "Berkay",
                    LastName = "Akar",
                    OptionalName = string.Empty,
                    Email = "m.berkay.akar@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+905345413410",
                    PhoneNumberConfirmed = true,
                    TwoFactorAuthenticaton = false,
                    AlwaysLockAccount = false,
                    LockOutEndDate = null,
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PasswordHash = PasswordHashHelper.CreateSha256Hash("12345678Ba"),
                    Status = true,
                    GendersId = 1,
                },

                new AppUser
                {
                    Id = 2,
                    IsActive = true,
                    UserName = StringConversation.NormalizeUpperCase("Ahmet"),
                    FirstName = "Ahmet",
                    LastName = "Akar",
                    OptionalName = string.Empty,
                    Email = "ahmet.akar@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+90111111111",
                    PhoneNumberConfirmed = true,
                    TwoFactorAuthenticaton = false,
                    AlwaysLockAccount = false,
                    LockOutEndDate = null,
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PasswordHash = PasswordHashHelper.CreateSha256Hash("12345678Ba"),
                    Status = true,
                    GendersId = 1,
                });
        }
    }
}
