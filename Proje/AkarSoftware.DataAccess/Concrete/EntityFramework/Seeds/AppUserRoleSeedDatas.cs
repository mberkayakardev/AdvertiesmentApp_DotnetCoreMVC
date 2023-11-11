using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Seeds
{
    public class AppUserRoleSeedDatas : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(

                // Berkay bir admindir
                new AppUserRole
                {
                    Id = 1,
                    IsActive = true,
                    AppUserId = 1,
                    BaseRoleId = 2,
                },

                // Ahmet bir aday dır.
                new AppUserRole
                {
                    Id = 2,
                    IsActive = true,
                    AppUserId = 2,
                    BaseRoleId = 1,
                }


                );
        }
    }
}
