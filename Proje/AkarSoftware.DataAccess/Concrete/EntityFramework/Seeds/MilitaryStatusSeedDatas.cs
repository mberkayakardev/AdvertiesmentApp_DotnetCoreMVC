using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Seeds
{
    public class MilitaryStatusSeedDatas : IEntityTypeConfiguration<MilitaryStatus>
    {
        public void Configure(EntityTypeBuilder<MilitaryStatus> builder)
        {
            builder.HasData(
                new MilitaryStatus
                {
                    Id = 1,
                    IsActive = true,
                    Status = "Yapıldı",
                    StatusDescription = "Askerliğini yapan kişiler için teşkil etmektedir."
                },

                new MilitaryStatus
                {
                    Id = 2,
                    IsActive = true,
                    Status = "Tecilli",
                    StatusDescription = "Askerliğini şuan için yapmamış ve yapma zorunluluğu olan kişiler için elverişlidir"
                },

                new MilitaryStatus
                {
                    Id = 3,
                    IsActive = true,
                    Status = "Muaf",
                    StatusDescription = "Askerlik durumunun muaf olması durumu temsil edilmektedir."
                },

                new MilitaryStatus
                {
                    Id = 4,
                    IsActive = true,
                    Status = "Yapılacak - Bedelli",
                    StatusDescription = "İlgili başvuruda başvuran adayın askerlik zorunluluğunun olduğu fakat bedelli kategorisinde ilgili sürecin gerçekleştirileceği planlanmıştır"
                });
        }
    }
}
