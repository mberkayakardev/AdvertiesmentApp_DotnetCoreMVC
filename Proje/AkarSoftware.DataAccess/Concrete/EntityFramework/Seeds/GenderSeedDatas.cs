using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Seeds
{
    public class GenderSeedDatas : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender
                {
                    Id = 1,
                    IsActive = true,
                    Name = "Erkek"
                },

                new Gender
                {
                    Id = 2,
                    IsActive = true,
                    Name = "Kadın"
                },
                
                new Gender
                {
                    Id = 3,
                    IsActive = true,
                    Name = "Belirtmek İstemiyor"
                });
        }
    }
}
