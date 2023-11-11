using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Seeds
{
    public class AppRoleSeedDatas : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {

            builder.HasData(
                new AppRole
                {
                    Id = 1,
                    IsActive = true,
                    RoleName = "Aday",
                    Description = "Sadece İş başvurularında bulunabilecek olan adaylar için roldür." 
                },

                new AppRole
                {
                    Id = 2,
                    IsActive = true,
                    RoleName = "Admin",
                    Description = "İlgili rol sistem yöneticilerine ve insan kaynakları için ayrılmıştır."
                });

        }
    }
}
