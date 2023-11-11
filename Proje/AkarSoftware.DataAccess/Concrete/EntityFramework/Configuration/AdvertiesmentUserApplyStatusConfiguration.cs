using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AdvertiesmentUserApplyStatusConfiguration : IEntityTypeConfiguration<AdvertiesmentUserApplyStatus>
    {
        public void Configure(EntityTypeBuilder<AdvertiesmentUserApplyStatus> builder)
        {
            builder.Property(x=> x.Status).HasMaxLength(200).IsRequired();
            builder.Property(x=> x.StatuDescription).HasMaxLength(2000).IsRequired();
        }
    }
}
