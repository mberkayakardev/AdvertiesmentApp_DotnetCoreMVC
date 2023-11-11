using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class MilitaryStatusConfiguration : IEntityTypeConfiguration<MilitaryStatus>
    {
        public void Configure(EntityTypeBuilder<MilitaryStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Status).HasMaxLength(300).IsRequired();
            builder.Property(x=> x.StatusDescription).HasMaxLength(1000).IsRequired();
        }
    }
}
