using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class ProviderServicesConfiguration : IEntityTypeConfiguration<ProviderServices>
    {
        public void Configure(EntityTypeBuilder<ProviderServices> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Title).HasMaxLength(300).IsRequired();
            builder.Property(x=> x.Description).HasColumnType("ntext").IsRequired();
            builder.Property(x=> x.CreatedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
